using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace lab3
{
    public partial class Form2 : Form
    {
        // 获取PgsqlAccess单例对象
        PgsqlAccess pg = PgsqlAccess.getInstance();

        // 连接数据库的变量
        NpgsqlConnection connection;
        NpgsqlDataAdapter dataAdapter;
        DataSet dataSet;

        // 当前表名
        string tableName;

        public Form2()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form2_load);
        }

        private void Form2_load(object sender, EventArgs e)
        {
            BindTree();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tableName = e.Node.Text.ToString();
            if (tableName != pg.DBname)
            {
                string sql = string.Format("select * from {0};", tableName);

                using (connection = pg.GetConnection())
                {
                    using (var dataAdapter = new NpgsqlDataAdapter(sql, connection))
                    {
                        using (DataSet ds = new DataSet())
                        {
                            dataAdapter.Fill(ds);
                            dgv.DataSource = ds.Tables[0];

                        }
                    }
                }
            }
        }
        
        //add nodes towards the treeview
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

        private void dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            using(connection = pg.GetConnection())
            {
                try
                {
                    string strColumn = dgv.Columns[e.ColumnIndex].HeaderText; //获取列标题
                    string strRow = dgv.Rows[e.RowIndex].Cells[0].Value.ToString(); //获取焦点触发行的第一个值
                    string value = dgv.CurrentCell.Value.ToString(); //获取当前点击的活动单元格的值
                    string strCmd = string.Format(
                        "update {0} set {1} = {2} where id = {3};", 
                        tableName, strColumn, value, strRow);
                    using(var cmd = new NpgsqlCommand(strCmd, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message.ToString());
                }
            }
        }
    }
}
