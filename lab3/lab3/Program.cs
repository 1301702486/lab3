using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Form1 Form1 = new Form1();

            //界面转换
            Form1.ShowDialog();

            if (Form1.DialogResult == DialogResult.OK)
            {
                Form1.Dispose();
                Application.Run(new Form2());
            }
            else if (Form1.DialogResult == DialogResult.Cancel)
            {
                Form1.Dispose();
                return;
            }

           
        }
    }
}
