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
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pgsqlAccessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelAlter = new System.Windows.Forms.Panel();
            this.buttonDone2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTypeName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelAddCol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgsqlAccessBindingSource)).BeginInit();
            this.panelAlter.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(24, 38);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(375, 593);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(16, 94);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 30;
            this.dgv.Size = new System.Drawing.Size(762, 485);
            this.dgv.TabIndex = 1;
            this.dgv.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgv_CellBeginEdit);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonAlter);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.buttonDrop);
            this.panel1.Controls.Add(this.buttonInsert);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonSelect);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.dgv);
            this.panel1.Location = new System.Drawing.Point(427, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 593);
            this.panel1.TabIndex = 2;
            // 
            // buttonAlter
            // 
            this.buttonAlter.Location = new System.Drawing.Point(694, 28);
            this.buttonAlter.Name = "buttonAlter";
            this.buttonAlter.Size = new System.Drawing.Size(87, 37);
            this.buttonAlter.TabIndex = 8;
            this.buttonAlter.Text = "Alter";
            this.buttonAlter.UseVisualStyleBackColor = true;
            this.buttonAlter.Click += new System.EventHandler(this.buttonAlter_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(597, 28);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(87, 37);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDrop
            // 
            this.buttonDrop.Location = new System.Drawing.Point(498, 28);
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
            this.panelAddCol.Controls.Add(this.buttonDone);
            this.panelAddCol.Controls.Add(this.label2);
            this.panelAddCol.Controls.Add(this.label1);
            this.panelAddCol.Controls.Add(this.textBoxDataType);
            this.panelAddCol.Controls.Add(this.textBoxColName);
            this.panelAddCol.Location = new System.Drawing.Point(104, 12);
            this.panelAddCol.Name = "panelAddCol";
            this.panelAddCol.Size = new System.Drawing.Size(286, 121);
            this.panelAddCol.TabIndex = 3;
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(91, 86);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(92, 32);
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
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Column name";
            // 
            // textBoxDataType
            // 
            this.textBoxDataType.Location = new System.Drawing.Point(167, 53);
            this.textBoxDataType.Name = "textBoxDataType";
            this.textBoxDataType.Size = new System.Drawing.Size(100, 30);
            this.textBoxDataType.TabIndex = 1;
            // 
            // textBoxColName
            // 
            this.textBoxColName.Location = new System.Drawing.Point(167, 17);
            this.textBoxColName.Name = "textBoxColName";
            this.textBoxColName.Size = new System.Drawing.Size(100, 30);
            this.textBoxColName.TabIndex = 0;
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
            // panelAlter
            // 
            this.panelAlter.Controls.Add(this.buttonDone2);
            this.panelAlter.Controls.Add(this.label3);
            this.panelAlter.Controls.Add(this.textBoxTypeName);
            this.panelAlter.Location = new System.Drawing.Point(406, 371);
            this.panelAlter.Name = "panelAlter";
            this.panelAlter.Size = new System.Drawing.Size(268, 100);
            this.panelAlter.TabIndex = 4;
            // 
            // buttonDone2
            // 
            this.buttonDone2.Location = new System.Drawing.Point(78, 53);
            this.buttonDone2.Name = "buttonDone2";
            this.buttonDone2.Size = new System.Drawing.Size(92, 32);
            this.buttonDone2.TabIndex = 7;
            this.buttonDone2.Text = "Done";
            this.buttonDone2.UseVisualStyleBackColor = true;
            this.buttonDone2.Click += new System.EventHandler(this.buttonDone2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data type";
            // 
            // textBoxTypeName
            // 
            this.textBoxTypeName.Location = new System.Drawing.Point(154, 20);
            this.textBoxTypeName.Name = "textBoxTypeName";
            this.textBoxTypeName.Size = new System.Drawing.Size(100, 30);
            this.textBoxTypeName.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 644);
            this.Controls.Add(this.panelAlter);
            this.Controls.Add(this.panelAddCol);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeView1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Postgres";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelAddCol.ResumeLayout(false);
            this.panelAddCol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgsqlAccessBindingSource)).EndInit();
            this.panelAlter.ResumeLayout(false);
            this.panelAlter.PerformLayout();
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
    }
}