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
        }

        private void Form2_load(object sender, EventArgs e)
        {
            BindTree();
        }

        private void GetPrikey(ref string pkname,ref string pkvalue)
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

            if (object.Equals(cellTempValue, dgv.Rows[currRow].Cells[currCol].Value))
            {
                //如果没有修改，则返回
                return;
            }

            string colName = dgv.Columns[currCol].DataPropertyName;
            string value = dgv.Rows[currRow].Cells[currCol].Value.ToString();
            string PkName = null;
            string PkValue = null;
            GetPrikey(ref PkName, ref PkValue);
           

            // 更新数据库
            pg.Update(tableName, colName, value, PkName, PkValue);
        }
        
        private void CellDelete()
        {
            //get present primary key and value to idetify the right row
            int currRow = dgv.CurrentCell.RowIndex;
            string pkName = null;
            string pkvalue = null;
            GetPrikey(ref pkName, ref pkvalue);
            DataGridViewRow currRow1 = dgv.CurrentRow;
            dgv.Rows.Remove(currRow1);
            pg.Delete(tableName, pkName, pkvalue);

        }

        // 删除列
        private void RemoveColumn()
        {
            int colIndex = dgv.CurrentCell.ColumnIndex;
            string colName = dgv.Columns[colIndex].DataPropertyName;
            dgv.Columns.RemoveAt(colIndex);
            pg.DropColumn(tableName, colName);
        }
        
   
        private void button1_Click(object sender, EventArgs e)
        {
            CellUpdate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CellDelete();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RemoveColumn();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //insert
        }

        // 增加列
        private void button6_Click(object sender, EventArgs e)
        {
            panelAddCol.Visible = true;            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string colName = textBoxColName.Text;
            string dataType = textBoxDataType.Text;
            pg.AddColumn(tableName, colName, dataType);
            panelAddCol.Visible = false;
        }
    }
}
