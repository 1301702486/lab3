using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Configuration;

namespace lab3
{
    public partial class Form2 : Form
    {
        // 获取PgsqlAccess单例
        PgsqlAccess pg = PgsqlAccess.getInstance();

        // 连接数据库的变量
        NpgsqlConnection connection;

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
            
            if (e.Node.Bounds.Contains(e.Location))
            {
                //表的内容显示
            }
        }
        //add nodes towards the treeview
        private void BindTree()
        {
            treeView1.BeginUpdate();
            TreeNode tNode = treeView1.Nodes.Add("whu");
            //connect to the database
            string sql = "SELECT tablename FROM pg_tables WHERE tablename NOT LIKE 'pg%' AND tablename NOT LIKE 'sql_%' ORDER BY tablename;";
            using (connection = pg.GetConnection())
            {
                using (var dataAdapter = new NpgsqlDataAdapter(sql, connection))
                {
                    using (DataSet ds = new DataSet())
                    {
                        dataAdapter.Fill(ds);
                        foreach (DataRow dr in ds.Tables[0].Rows)
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
