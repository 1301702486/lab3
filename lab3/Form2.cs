using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace lab3
{
    public partial class Form2 : Form
    {
        PgsqlAccess pg = PgsqlAccess.getInstance();
        
        NpgsqlConnection connection;
        NpgsqlDataAdapter dataAdapter;
        //NpgsqlCommandBuilder commandBuilder;
        DataSet dataSet;

        string tableName;

        object cellTempValue = null;


        public Form2()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form2_load);
            panelAddCol.Visible = false;
            panelAlter.Visible = false;
        }

        private void Form2_load(object sender, EventArgs e)
        {
            BindTree();
        }

        private void GetPrimarykey(ref string pkname,ref string pkvalue)
        {
            int currCol = dgv.CurrentCell.ColumnIndex;    // 单元格当前所在列
            int currRow = dgv.CurrentCell.RowIndex;       // 单元格当前所在行
            string PkName = null;
            string PkValue = null;

            // 获取PkName和PkValue
            using (connection = pg.GetConnection())
            {
                string str = "select * from " + tableName + " ;";
                using (dataAdapter = new NpgsqlDataAdapter(str, connection))
                {
                    using (dataSet = new DataSet())
                    {
                        // 获取PkName
                        dataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                        dataAdapter.Fill(dataSet);
                        PkName = dataSet.Tables[0].PrimaryKey[0].ColumnName;
                        pkname = PkName;
                        // 获取主键所在列
                        int keyCol = 0;
                        for (int i = 0; i < dataSet.Tables[0].Columns.Count; ++i)
                        {
                            if (dataSet.Tables[0].Columns[i].ColumnName == PkName)
                            {
                                keyCol = i;
                                break;
                            }
                        }

                        // 获取PkValue
                        PkValue = dataSet.Tables[0].Rows[currRow][keyCol].ToString();
                        pkvalue = PkValue;
                    }
                }
            }
        }

        // 选择表后在DataGridView中显示出来
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tableName = e.Node.Text.ToString();
            if (tableName != pg.DBname)
            {
                string sql = string.Format("select * from {0};", tableName);
                using (connection = pg.GetConnection())
                {
                    using (dataAdapter = new NpgsqlDataAdapter(sql, connection))
                    {
                        using (dataSet = new DataSet())
                        {
                            dataAdapter.Fill(dataSet);
                            dgv.DataSource = dataSet.Tables[0];
                        }
                    }
                }
            }
        }

        // 在treeview中添加节点
        private void BindTree()
        {
            treeView1.BeginUpdate();
            TreeNode tNode = treeView1.Nodes.Add("whu");
            // 连接数据库
            string sql = "SELECT tablename FROM pg_tables WHERE tablename NOT LIKE 'pg%' AND tablename NOT LIKE 'sql_%' ORDER BY tablename;";
            using (connection = pg.GetConnection()) //用了using所以不需要关闭了
            {
                using (dataAdapter = new NpgsqlDataAdapter(sql, connection))
                {
                    using (dataSet = new DataSet())
                    {
                        dataAdapter.Fill(dataSet);
                        foreach (DataRow dr in dataSet.Tables[0].Rows)
                        {
                            // 产生子节点(列出当前数据库中所有表名)
                            treeView1.Nodes[0].Nodes.Add(dr[0].ToString());
                        }
                    }
                }
            }
            treeView1.EndUpdate();
        }

        // 获取修改前单元格值
        private void dgv_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            cellTempValue = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }

        private void CellUpdate()
        {
            int currCol = dgv.CurrentCell.ColumnIndex;    // 单元格当前所在列
            int currRow = dgv.CurrentCell.RowIndex;       // 单元格当前所在行

            if (Equals(cellTempValue, dgv.Rows[currRow].Cells[currCol].Value))
            {
                //如果没有修改，则返回
                return;
            }

            string colName = dgv.Columns[currCol].DataPropertyName;
            string value = dgv.Rows[currRow].Cells[currCol].Value.ToString();
            string PkName = null;
            string PkValue = null;
            GetPrimarykey(ref PkName, ref PkValue);

            // 更新数据库
            pg.Update(tableName, colName, value, PkName, PkValue);
        }
        
        private void CellDelete()
        {
            //get present primary key and value to idetify the right row
            int currRow = dgv.CurrentCell.RowIndex;
            string pkName = null;
            string pkValue = null;
            GetPrimarykey(ref pkName, ref pkValue);
            DataGridViewRow currRow1 = dgv.CurrentRow;
            dgv.Rows.Remove(currRow1);
            pg.Delete(tableName, pkName, pkValue);

        }

        private void RemoveColumn()
        {
            int colIndex = dgv.CurrentCell.ColumnIndex;
            string colName = dgv.Columns[colIndex].DataPropertyName;
            dgv.Columns.RemoveAt(colIndex);
            pg.DropColumn(tableName, colName);
        }

        // 更新数据
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            CellUpdate();
        }

        // 删除一行数据
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            CellDelete();
        }

        // 插入一行数据
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string colList = null;
            string valueList = null;
            Insert(ref colList, ref valueList);
            try
            {
                pg.Insert(tableName, colList, valueList);
            }
            catch(Exception)
            {
                MessageBox.Show("您必须为所有非空属性赋值!");
            }
            
        }
        private void Insert(ref string colList, ref string valueList)
        {
            string columns = "(";
            string values = "(";
            int total = dgv.ColumnCount;
            int currRow = dgv.CurrentCell.RowIndex;
            
            for (int i = 0; i < total - 1; ++i)
            {
                if(dgv.Rows[currRow].Cells[i].Value.ToString() != "")
                {
                    
                    columns += dgv.Columns[i].DataPropertyName;
                    columns += ",";

                    values += "'";
                    values += dgv.Rows[currRow].Cells[i].Value.ToString();
                    values += "',";
                }
            }
            string subCols = columns.Substring(0, columns.Length - 1);
            string subVals = values.Substring(0, values.Length - 1);

            columns = subCols + ")";
            
            values = subVals + ")";

            colList = columns;
            valueList = values;
        }

        // 删除列
        private void buttonDrop_Click(object sender, EventArgs e)
        {
            RemoveColumn();
        }

        // 增加列
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            panelAddCol.Visible = true;
        }
        private void buttonDone_Click(object sender, EventArgs e)
        {
            string colName = textBoxColName.Text;
            string dataType = textBoxDataType.Text;
            pg.AddColumn(tableName, colName, dataType);
            panelAddCol.Visible = false;
        }

        // 修改列的数据类型
        private void buttonAlter_Click(object sender, EventArgs e)
        {
            panelAlter.Visible = true;
        }
        private void buttonDone2_Click(object sender, EventArgs e)
        {
            int currCol = dgv.CurrentCell.ColumnIndex;
            string colName = dgv.Columns[currCol].DataPropertyName;
            string dataType = textBoxTypeName.Text;
            pg.AlterColumn(tableName, colName, dataType);
            panelAlter.Visible = false;
        }
    }
}
