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

        // 枚举表名
        enum TableName
        {
            course,
            cs,
            student
        }

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
            string name = e.Node.Text.ToString();
            string sql;

            if (name == "course")
            {
                sql = "select * from course;";
                using (connection = pg.GetConnection())
                {
                    using (var dataAdapter = new NpgsqlDataAdapter(sql, connection))
                    {
                        using (DataSet ds = new DataSet())
                        {
                            dataAdapter.Fill(ds);
                            dataGridView1.DataSource = ds.Tables[0];
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
            //connect to the database
            string sql = "SELECT tablename FROM pg_tables WHERE tablename NOT LIKE 'pg%' AND tablename NOT LIKE 'sql_%' ORDER BY tablename;";
            using (connection = pg.GetConnection())//用了using所以不需要关闭了
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
        
        //感觉下面的可以删掉
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
