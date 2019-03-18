namespace pgManager
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelTree = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxHost = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDBName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPswd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTree.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelTree
            // 
            this.panelTree.Controls.Add(this.treeView1);
            this.panelTree.Location = new System.Drawing.Point(0, 0);
            this.panelTree.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTree.Name = "panelTree";
            this.panelTree.Size = new System.Drawing.Size(240, 665);
            this.panelTree.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(14, 14);
            this.treeView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(222, 634);
            this.treeView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label1.Location = new System.Drawing.Point(538, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host:";
            // 
            // textBoxHost
            // 
            this.textBoxHost.AcceptsTab = true;
            this.textBoxHost.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.textBoxHost.Location = new System.Drawing.Point(651, 139);
            this.textBoxHost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxHost.Name = "textBoxHost";
            this.textBoxHost.Size = new System.Drawing.Size(320, 37);
            this.textBoxHost.TabIndex = 2;
            this.textBoxHost.Text = "localhost";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(995, 534);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OK_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label3.Location = new System.Drawing.Point(475, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "User name:";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.AcceptsTab = true;
            this.textBoxUserName.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.textBoxUserName.Location = new System.Drawing.Point(651, 204);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(320, 37);
            this.textBoxUserName.TabIndex = 3;
            this.textBoxUserName.Text = "postgres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label4.Location = new System.Drawing.Point(433, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Database name:";
            // 
            // textBoxDBName
            // 
            this.textBoxDBName.AcceptsTab = true;
            this.textBoxDBName.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.textBoxDBName.Location = new System.Drawing.Point(651, 275);
            this.textBoxDBName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDBName.Name = "textBoxDBName";
            this.textBoxDBName.Size = new System.Drawing.Size(320, 37);
            this.textBoxDBName.TabIndex = 4;
            this.textBoxDBName.Text = "whu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label5.Location = new System.Drawing.Point(498, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password:";
            // 
            // textBoxPswd
            // 
            this.textBoxPswd.AcceptsTab = true;
            this.textBoxPswd.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.textBoxPswd.Location = new System.Drawing.Point(651, 345);
            this.textBoxPswd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPswd.Name = "textBoxPswd";
            this.textBoxPswd.PasswordChar = '*';
            this.textBoxPswd.Size = new System.Drawing.Size(320, 37);
            this.textBoxPswd.TabIndex = 1;
            this.textBoxPswd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPswd_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label6.Location = new System.Drawing.Point(544, 435);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 30);
            this.label6.TabIndex = 10;
            this.label6.Text = "Port:";
            // 
            // textBoxPort
            // 
            this.textBoxPort.AcceptsTab = true;
            this.textBoxPort.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.textBoxPort.Location = new System.Drawing.Point(651, 432);
            this.textBoxPort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(320, 37);
            this.textBoxPort.TabIndex = 5;
            this.textBoxPort.Text = "5432";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(250, 505);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 30);
            this.label2.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxPort);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxPswd);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxDBName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxUserName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBoxHost);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1279, 684);
            this.panel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 693);
            this.Controls.Add(this.panelTree);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTree.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelTree;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxHost;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDBName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPswd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}

