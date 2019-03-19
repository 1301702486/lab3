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
        PgsqlAccess pg = PgsqlAccess.getInstance();

        public Form1()
        {
            InitializeComponent();
        }

        //after you click OK,exam weather your password is right
        private void button1_Click(object sender, EventArgs e)
        {   //open the database
            pg.Host = textBox2.Text;
            pg.User = textBox3.Text;
            pg.DBname = textBox4.Text;
            pg.Password = textBox1.Text;
            pg.Port = textBox5.Text;
            //NpgsqlConnection conn = null;
            //try
            //{
            //    string connStr = string.Format(
            //            "Server={0}; User Id={1}; Database={2}; Port={3}; Password={4};",
            //            pg.Host,
            //            pg.User,
            //            pg.DBname,
            //            pg.Port,
            //            pg.Password);
            //    conn = new NpgsqlConnection(connStr);
            //    conn.Open();

            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Wrong password!");
            //    Application.Exit();
            //}
            //finally
            //{
            //    if (conn != null)
            //    {
            //        conn.Close();
            //    }
            //    //change to form2, one of the operations
            //    this.DialogResult = DialogResult.OK;
            //    this.Dispose();
            //    this.Close();
            //}
            try
            {
                var conn = pg.GetConnection();
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
        
    }
}
