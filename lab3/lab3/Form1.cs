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
        private static string Host = "localhost";
        private static string User = "postgres";
        private static string DBname = "whu";
        private static string Password = "postgres";
        private static string Port = "5432";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //afteryou click OK,exam weather your password is right
        private void button1_Click(object sender, EventArgs e)
        {   //open the database
            Host = textBox2.Text;
            User = textBox3.Text;
            DBname = textBox4.Text;
            Password = textBox1.Text;
            Port = textBox5.Text;
            NpgsqlConnection conn = null;
            try
            {
                string connStr = string.Format(
                        "Server={0}; User Id={1}; Database={2}; Port={3}; Password={4};",
                        Host,
                        User,
                        DBname,
                        Port,
                        Password);
                conn = new NpgsqlConnection(connStr);
                conn.Open();

            }
            catch (Exception)
            {
                MessageBox.Show("Wrong password!");
                Application.Exit();
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
                //change to form2, one of the operations
                this.DialogResult = DialogResult.OK;
                this.Dispose();
                this.Close();
            }


        }





      
        //cancle your operation

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
