using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace pgManager
{
    public partial class Form1 : Form
    {
        private static string Host = "localhost";
        private static string User = "postgres";
        private static string DBname = "whu";
        private static string Password = "postgres";
        private static string Port = "5432";

        public Form1()
        {
            InitializeComponent();
            panelTree.Visible = false;
        }

        public static NpgsqlConnection GetConnection()
        {
            string connStr = string.Format(
                        "Server={0}; User Id={1}; Database={2}; Port={3}; Password={4};",
                        Host,
                        User,
                        DBname,
                        Port,
                        Password);
            var conn = new NpgsqlConnection(connStr);
            conn.Open();
            return conn;
        }

        

        // 简易版insert（插入一个单值）
        public static void Insert(string tableName, string colName, string value)
        {
            using (var conn = GetConnection())
            {
                string insertStr = string.Format(
                        "insert into {0} {1} values @value;",
                        tableName,
                        colName);
                using (var cmd = new NpgsqlCommand(insertStr, conn))
                {
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@value", value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // 简易版update（把colName列的所有值改为value）
        public static void Update(string tableName, string colName, string value)
        {
            using (var conn = GetConnection())
            {
                string updateStr = string.Format(
                        "update {0} set {1} = @value;",
                        tableName,
                        colName);
                using (var cmd = new NpgsqlCommand(updateStr, conn))
                {
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@value", value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // 简易版delete（删除所有colName=value的记录）
        public static void Delete(string tableName, string colName, string value)
        {
            using (var conn = GetConnection())
            {
                string deleteStr = string.Format(
                    "delete from {0} where {1} = {2};",
                    tableName,
                    colName,
                    value);
                using (var cmd = new NpgsqlCommand(deleteStr, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            Host = textBoxHost.Text;
            User = textBoxUserName.Text;
            DBname = textBoxDBName.Text;
            Password = textBoxPswd.Text;
            Port = textBoxPort.Text;
            var conn = GetConnection();
            label2.Text = "登录成功！";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panelTree.Visible = true;
            InitTreeView();
            timer1.Stop();
        }

        private void InitTreeView()
        {
            treeView1.BeginUpdate();
            treeView1.CheckBoxes = false;
            TreeNode tNode = treeView1.Nodes.Add(DBname);
            using (var conn = GetConnection())
            {
                string sql = "SELECT tablename FROM pg_tables WHERE tablename NOT LIKE 'pg%' AND tablename NOT LIKE 'sql_%' ORDER BY tablename;";
                using (var dataAdapter = new NpgsqlDataAdapter(sql, conn))
                {
                    using(DataSet ds = new DataSet())
                    {
                        dataAdapter.Fill(ds);
                        foreach(DataRow dr in ds.Tables[0].Rows)
                        {
                            // 产生子节点(列出当前数据库中所有表名)
                            treeView1.Nodes[0].Nodes.Add(dr[0].ToString());
                        }
                    }
                }
            }
            treeView1.EndUpdate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxPswd_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
