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

namespace lab3
{
    public partial class Form1 : Form
    {
        // 获取PgsqlAccess单例
        PgsqlAccess pg = PgsqlAccess.getInstance();

        public Form1()
        {
            InitializeComponent();
        }

        //after you click OK,exam weather your password is right
        private void button1_Click(object sender, EventArgs e)
        {   
            //open the database
            pg.Host = textBoxHost.Text;
            pg.User = textBoxUserName.Text;
            pg.DBname = textBoxDB.Text;
            pg.Password = textBoxPswd.Text;
            pg.Port = textBoxPort.Text;
            NpgsqlConnection conn = null;
            try
            {
                conn = pg.GetConnection();
                this.DialogResult = DialogResult.OK;
                this.Dispose();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong password!");
                Application.Exit();
            }
        }

        //cancle your operation

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxPswd_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 按回车键直接登录
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                button1_Click(sender, e);
            }
        }
    }
}
