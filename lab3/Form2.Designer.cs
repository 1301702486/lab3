namespace lab3
{
    partial class Form2
    {        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
       
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAlter = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDrop = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.panelAddCol = new System.Windows.Forms.Panel();
            this.buttonDone = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDataType = new System.Windows.Forms.TextBox();
            this.textBoxColName = new System.Windows.Forms.TextBox();
            this.panelAlter = new System.Windows.Forms.Panel();
            this.buttonDone2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTypeName = new System.Windows.Forms.TextBox();
            this.panelSelect = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonClose1 = new System.Windows.Forms.Button();
            this.buttonClose2 = new System.Windows.Forms.Button();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pgsqlAccessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelAddCol.SuspendLayout();
            this.panelAlter.SuspendLayout();
            this.panelSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgsqlAccessBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(24, 191);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(337, 411);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(39, 136);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 30;
            this.dgv.Size = new System.Drawing.Size(470, 411);
            this.dgv.TabIndex = 1;
            this.dgv.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgv_CellBeginEdit);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonAlter);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.buttonDrop);
            this.panel1.Controls.Add(this.buttonInsert);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonSelect);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.dgv);
            this.panel1.Location = new System.Drawing.Point(425, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 565);
            this.panel1.TabIndex = 2;
            // 
            // buttonAlter
            // 
            this.buttonAlter.Location = new System.Drawing.Point(337, 82);
            this.buttonAlter.Name = "buttonAlter";
            this.buttonAlter.Size = new System.Drawing.Size(87, 37);
            this.buttonAlter.TabIndex = 8;
            this.buttonAlter.Text = "Alter";
            this.buttonAlter.UseVisualStyleBackColor = true;
            this.buttonAlter.Click += new System.EventHandler(this.buttonAlter_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(220, 83);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(87, 37);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDrop
            // 
            this.buttonDrop.Location = new System.Drawing.Point(101, 83);
            this.buttonDrop.Name = "buttonDrop";
            this.buttonDrop.Size = new System.Drawing.Size(87, 37);
            this.buttonDrop.TabIndex = 6;
            this.buttonDrop.Text = "Drop";
            this.buttonDrop.UseVisualStyleBackColor = true;
            this.buttonDrop.Click += new System.EventHandler(this.buttonDrop_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(388, 28);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(89, 37);
            this.buttonInsert.TabIndex = 5;
            this.buttonInsert.Text = "insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(272, 28);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(91, 37);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(159, 28);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(88, 37);
            this.buttonSelect.TabIndex = 3;
            this.buttonSelect.Text = "select";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(39, 28);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(96, 37);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panelAddCol
            // 
            this.panelAddCol.Controls.Add(this.buttonClose2);
            this.panelAddCol.Controls.Add(this.buttonDone);
            this.panelAddCol.Controls.Add(this.label2);
            this.panelAddCol.Controls.Add(this.label1);
            this.panelAddCol.Controls.Add(this.textBoxDataType);
            this.panelAddCol.Controls.Add(this.textBoxColName);
            this.panelAddCol.Location = new System.Drawing.Point(24, 26);
            this.panelAddCol.Name = "panelAddCol";
            this.panelAddCol.Size = new System.Drawing.Size(337, 153);
            this.panelAddCol.TabIndex = 3;
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(33, 93);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(92, 43);
            this.buttonDone.TabIndex = 4;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Column name";
            // 
            // textBoxDataType
            // 
            this.textBoxDataType.Location = new System.Drawing.Point(167, 53);
            this.textBoxDataType.Name = "textBoxDataType";
            this.textBoxDataType.Size = new System.Drawing.Size(137, 34);
            this.textBoxDataType.TabIndex = 1;
            // 
            // textBoxColName
            // 
            this.textBoxColName.Location = new System.Drawing.Point(167, 17);
            this.textBoxColName.Name = "textBoxColName";
            this.textBoxColName.Size = new System.Drawing.Size(137, 34);
            this.textBoxColName.TabIndex = 0;
            // 
            // panelAlter
            // 
            this.panelAlter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelAlter.Controls.Add(this.buttonClose1);
            this.panelAlter.Controls.Add(this.buttonDone2);
            this.panelAlter.Controls.Add(this.label3);
            this.panelAlter.Controls.Add(this.textBoxTypeName);
            this.panelAlter.Location = new System.Drawing.Point(24, 26);
            this.panelAlter.Name = "panelAlter";
            this.panelAlter.Size = new System.Drawing.Size(337, 153);
            this.panelAlter.TabIndex = 4;
            // 
            // buttonDone2
            // 
            this.buttonDone2.Location = new System.Drawing.Point(47, 81);
            this.buttonDone2.Name = "buttonDone2";
            this.buttonDone2.Size = new System.Drawing.Size(92, 36);
            this.buttonDone2.TabIndex = 7;
            this.buttonDone2.Text = "Done";
            this.buttonDone2.UseVisualStyleBackColor = true;
            this.buttonDone2.Click += new System.EventHandler(this.buttonDone2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data type";
            // 
            // textBoxTypeName
            // 
            this.textBoxTypeName.Location = new System.Drawing.Point(131, 20);
            this.textBoxTypeName.Name = "textBoxTypeName";
            this.textBoxTypeName.Size = new System.Drawing.Size(151, 34);
            this.textBoxTypeName.TabIndex = 5;
            // 
            // panelSelect
            // 
            this.panelSelect.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelSelect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSelect.Controls.Add(this.button1);
            this.panelSelect.Controls.Add(this.textBox2);
            this.panelSelect.Controls.Add(this.label5);
            this.panelSelect.Controls.Add(this.textBox1);
            this.panelSelect.Controls.Add(this.label4);
            this.panelSelect.Location = new System.Drawing.Point(24, 26);
            this.panelSelect.Name = "panelSelect";
            this.panelSelect.Size = new System.Drawing.Size(337, 153);
            this.panelSelect.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "where";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Beige;
            this.textBox1.Location = new System.Drawing.Point(89, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 34);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "colName\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "=";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Beige;
            this.textBox2.Location = new System.Drawing.Point(218, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 34);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Value";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonClose1
            // 
            this.buttonClose1.Location = new System.Drawing.Point(181, 81);
            this.buttonClose1.Name = "buttonClose1";
            this.buttonClose1.Size = new System.Drawing.Size(86, 36);
            this.buttonClose1.TabIndex = 8;
            this.buttonClose1.Text = "Close";
            this.buttonClose1.UseVisualStyleBackColor = true;
            this.buttonClose1.Click += new System.EventHandler(this.buttonClose1_Click);
            // 
            // buttonClose2
            // 
            this.buttonClose2.Location = new System.Drawing.Point(167, 93);
            this.buttonClose2.Name = "buttonClose2";
            this.buttonClose2.Size = new System.Drawing.Size(100, 43);
            this.buttonClose2.TabIndex = 5;
            this.buttonClose2.Text = "Close";
            this.buttonClose2.UseVisualStyleBackColor = true;
            this.buttonClose2.Click += new System.EventHandler(this.buttonClose2_Click);
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(lab3.Program);
            // 
            // form2BindingSource
            // 
            this.form2BindingSource.DataSource = typeof(lab3.Form2);
            // 
            // pgsqlAccessBindingSource
            // 
            this.pgsqlAccessBindingSource.DataSource = typeof(PgsqlAccess);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1035, 615);
            this.Controls.Add(this.panelSelect);
            this.Controls.Add(this.panelAlter);
            this.Controls.Add(this.panelAddCol);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeView1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Postgres";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelAddCol.ResumeLayout(false);
            this.panelAddCol.PerformLayout();
            this.panelAlter.ResumeLayout(false);
            this.panelAlter.PerformLayout();
            this.panelSelect.ResumeLayout(false);
            this.panelSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgsqlAccessBindingSource)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.BindingSource pgsqlAccessBindingSource;
        private System.Windows.Forms.BindingSource form2BindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDrop;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panelAddCol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDataType;
        private System.Windows.Forms.TextBox textBoxColName;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonAlter;
        private System.Windows.Forms.Panel panelAlter;
        private System.Windows.Forms.Button buttonDone2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTypeName;
        private System.Windows.Forms.Panel panelSelect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonClose1;
        private System.Windows.Forms.Button buttonClose2;
    }
}