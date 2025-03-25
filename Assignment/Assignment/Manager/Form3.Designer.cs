namespace Assignment.Manager
{
    partial class Form3
    {
        /// <summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddHalls = new System.Windows.Forms.Button();
            this.btnEditHall = new System.Windows.Forms.Button();
            this.btnDeleteHall = new System.Windows.Forms.Button();
            this.hallsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.iOOP_DatabaseDataSet2 = new Assignment.IOOP_DatabaseDataSet2();
            this.hallsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.hallsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iOOP_DatabaseDataSet = new Assignment.IOOP_DatabaseDataSet();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.btnSaveAdd = new System.Windows.Forms.Button();
            this.comboAvailability1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCapacity1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHallID1 = new System.Windows.Forms.TextBox();
            this.lblHallID1 = new System.Windows.Forms.Label();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.txtHallID2 = new System.Windows.Forms.TextBox();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.comboAvailability2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCapacity2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelDelete = new System.Windows.Forms.Panel();
            this.btnSaveDelete = new System.Windows.Forms.Button();
            this.txtHallID3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.iOOP_DatabaseDataSet1 = new Assignment.IOOP_DatabaseDataSet1();
            this.hallsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hallsTableAdapter = new Assignment.IOOP_DatabaseDataSet2TableAdapters.HallsTableAdapter();
            this.iOOP_DatabaseDataSet3 = new Assignment.IOOP_DatabaseDataSet3();
            this.hallsBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.hallsTableAdapter1 = new Assignment.IOOP_DatabaseDataSet3TableAdapters.HallsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.hallsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_DatabaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hallsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hallsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_DatabaseDataSet)).BeginInit();
            this.panelAdd.SuspendLayout();
            this.panelEdit.SuspendLayout();
            this.panelDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_DatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hallsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_DatabaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hallsBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(357, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manager- Manage Halls";
            // 
            // btnAddHalls
            // 
            this.btnAddHalls.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAddHalls.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHalls.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAddHalls.Location = new System.Drawing.Point(814, 221);
            this.btnAddHalls.Name = "btnAddHalls";
            this.btnAddHalls.Size = new System.Drawing.Size(167, 77);
            this.btnAddHalls.TabIndex = 2;
            this.btnAddHalls.Text = "Add New Hall";
            this.btnAddHalls.UseVisualStyleBackColor = false;
            this.btnAddHalls.Click += new System.EventHandler(this.btnAddHalls_Click);
            // 
            // btnEditHall
            // 
            this.btnEditHall.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEditHall.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditHall.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnEditHall.Location = new System.Drawing.Point(814, 336);
            this.btnEditHall.Name = "btnEditHall";
            this.btnEditHall.Size = new System.Drawing.Size(167, 77);
            this.btnEditHall.TabIndex = 3;
            this.btnEditHall.Text = "Edit Hall";
            this.btnEditHall.UseVisualStyleBackColor = false;
            this.btnEditHall.Click += new System.EventHandler(this.btnEditHall_Click);
            // 
            // btnDeleteHall
            // 
            this.btnDeleteHall.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDeleteHall.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteHall.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnDeleteHall.Location = new System.Drawing.Point(814, 448);
            this.btnDeleteHall.Name = "btnDeleteHall";
            this.btnDeleteHall.Size = new System.Drawing.Size(167, 77);
            this.btnDeleteHall.TabIndex = 4;
            this.btnDeleteHall.Text = "Delete Hall";
            this.btnDeleteHall.UseVisualStyleBackColor = false;
            this.btnDeleteHall.Click += new System.EventHandler(this.btnDeleteHall_Click);
            // 
            // hallsBindingSource3
            // 
            this.hallsBindingSource3.DataMember = "Halls";
            this.hallsBindingSource3.DataSource = this.iOOP_DatabaseDataSet2;
            // 
            // iOOP_DatabaseDataSet2
            // 
            this.iOOP_DatabaseDataSet2.DataSetName = "IOOP_DatabaseDataSet2";
            this.iOOP_DatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hallsBindingSource2
            // 
            this.hallsBindingSource2.DataMember = "Halls";
            // 
            // hallsBindingSource
            // 
            this.hallsBindingSource.DataSource = this.iOOP_DatabaseDataSet;
            this.hallsBindingSource.Position = 0;
            // 
            // iOOP_DatabaseDataSet
            // 
            this.iOOP_DatabaseDataSet.DataSetName = "IOOP_DatabaseDataSet";
            this.iOOP_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelAdd
            // 
            this.panelAdd.BackColor = System.Drawing.Color.DarkOrange;
            this.panelAdd.Controls.Add(this.btnSaveAdd);
            this.panelAdd.Controls.Add(this.comboAvailability1);
            this.panelAdd.Controls.Add(this.label5);
            this.panelAdd.Controls.Add(this.txtCapacity1);
            this.panelAdd.Controls.Add(this.label4);
            this.panelAdd.Controls.Add(this.txtHallID1);
            this.panelAdd.Controls.Add(this.lblHallID1);
            this.panelAdd.Location = new System.Drawing.Point(44, 142);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(275, 370);
            this.panelAdd.TabIndex = 6;
            this.panelAdd.Visible = false;
            // 
            // btnSaveAdd
            // 
            this.btnSaveAdd.Location = new System.Drawing.Point(98, 248);
            this.btnSaveAdd.Name = "btnSaveAdd";
            this.btnSaveAdd.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAdd.TabIndex = 8;
            this.btnSaveAdd.Text = "Save";
            this.btnSaveAdd.UseVisualStyleBackColor = true;
            this.btnSaveAdd.Click += new System.EventHandler(this.btnSaveAdd_Click);
            // 
            // comboAvailability1
            // 
            this.comboAvailability1.FormattingEnabled = true;
            this.comboAvailability1.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.comboAvailability1.Location = new System.Drawing.Point(119, 167);
            this.comboAvailability1.Name = "comboAvailability1";
            this.comboAvailability1.Size = new System.Drawing.Size(121, 24);
            this.comboAvailability1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(33, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Availability";
            // 
            // txtCapacity1
            // 
            this.txtCapacity1.Location = new System.Drawing.Point(119, 107);
            this.txtCapacity1.Name = "txtCapacity1";
            this.txtCapacity1.Size = new System.Drawing.Size(100, 22);
            this.txtCapacity1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(33, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Capacity";
            // 
            // txtHallID1
            // 
            this.txtHallID1.Location = new System.Drawing.Point(119, 47);
            this.txtHallID1.Name = "txtHallID1";
            this.txtHallID1.ReadOnly = true;
            this.txtHallID1.Size = new System.Drawing.Size(100, 22);
            this.txtHallID1.TabIndex = 1;
            // 
            // lblHallID1
            // 
            this.lblHallID1.AutoSize = true;
            this.lblHallID1.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHallID1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHallID1.Location = new System.Drawing.Point(33, 47);
            this.lblHallID1.Name = "lblHallID1";
            this.lblHallID1.Size = new System.Drawing.Size(50, 19);
            this.lblHallID1.TabIndex = 0;
            this.lblHallID1.Text = "Hall ID";
            // 
            // panelEdit
            // 
            this.panelEdit.BackColor = System.Drawing.Color.DarkOrange;
            this.panelEdit.Controls.Add(this.txtHallID2);
            this.panelEdit.Controls.Add(this.btnSaveEdit);
            this.panelEdit.Controls.Add(this.comboAvailability2);
            this.panelEdit.Controls.Add(this.label7);
            this.panelEdit.Controls.Add(this.txtCapacity2);
            this.panelEdit.Controls.Add(this.label6);
            this.panelEdit.Controls.Add(this.label2);
            this.panelEdit.Location = new System.Drawing.Point(384, 142);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(275, 370);
            this.panelEdit.TabIndex = 7;
            this.panelEdit.Visible = false;
            // 
            // txtHallID2
            // 
            this.txtHallID2.Location = new System.Drawing.Point(131, 47);
            this.txtHallID2.Name = "txtHallID2";
            this.txtHallID2.Size = new System.Drawing.Size(100, 22);
            this.txtHallID2.TabIndex = 11;
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.Location = new System.Drawing.Point(108, 256);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(75, 23);
            this.btnSaveEdit.TabIndex = 9;
            this.btnSaveEdit.Text = "Save";
            this.btnSaveEdit.UseVisualStyleBackColor = true;
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click_1);
            // 
            // comboAvailability2
            // 
            this.comboAvailability2.FormattingEnabled = true;
            this.comboAvailability2.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.comboAvailability2.Location = new System.Drawing.Point(131, 167);
            this.comboAvailability2.Name = "comboAvailability2";
            this.comboAvailability2.Size = new System.Drawing.Size(121, 24);
            this.comboAvailability2.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(45, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Availability";
            // 
            // txtCapacity2
            // 
            this.txtCapacity2.Location = new System.Drawing.Point(141, 107);
            this.txtCapacity2.Name = "txtCapacity2";
            this.txtCapacity2.Size = new System.Drawing.Size(100, 22);
            this.txtCapacity2.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(55, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Capacity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(55, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hall ID";
            // 
            // panelDelete
            // 
            this.panelDelete.BackColor = System.Drawing.Color.DarkOrange;
            this.panelDelete.Controls.Add(this.btnSaveDelete);
            this.panelDelete.Controls.Add(this.txtHallID3);
            this.panelDelete.Controls.Add(this.label3);
            this.panelDelete.Location = new System.Drawing.Point(735, 142);
            this.panelDelete.Name = "panelDelete";
            this.panelDelete.Size = new System.Drawing.Size(275, 370);
            this.panelDelete.TabIndex = 8;
            this.panelDelete.Visible = false;
            // 
            // btnSaveDelete
            // 
            this.btnSaveDelete.Location = new System.Drawing.Point(97, 152);
            this.btnSaveDelete.Name = "btnSaveDelete";
            this.btnSaveDelete.Size = new System.Drawing.Size(75, 23);
            this.btnSaveDelete.TabIndex = 6;
            this.btnSaveDelete.Text = "Delete";
            this.btnSaveDelete.UseVisualStyleBackColor = true;
            this.btnSaveDelete.Click += new System.EventHandler(this.btnSaveDelete_Click_1);
            // 
            // txtHallID3
            // 
            this.txtHallID3.Location = new System.Drawing.Point(138, 47);
            this.txtHallID3.Name = "txtHallID3";
            this.txtHallID3.Size = new System.Drawing.Size(100, 22);
            this.txtHallID3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(52, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hall ID";
            // 
            // iOOP_DatabaseDataSet1
            // 
            this.iOOP_DatabaseDataSet1.DataSetName = "IOOP_DatabaseDataSet1";
            this.iOOP_DatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hallsBindingSource1
            // 
            this.hallsBindingSource1.DataMember = "Halls";
            this.hallsBindingSource1.DataSource = this.iOOP_DatabaseDataSet1;
            // 
            // hallsTableAdapter
            // 
            this.hallsTableAdapter.ClearBeforeFill = true;
            // 
            // iOOP_DatabaseDataSet3
            // 
            this.iOOP_DatabaseDataSet3.DataSetName = "IOOP_DatabaseDataSet3";
            this.iOOP_DatabaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hallsBindingSource4
            // 
            this.hallsBindingSource4.DataMember = "Halls";
            this.hallsBindingSource4.DataSource = this.iOOP_DatabaseDataSet3;
            // 
            // hallsTableAdapter1
            // 
            this.hallsTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView1.DataSource = this.hallsBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(47, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(428, 276);
            this.dataGridView1.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "HallID";
            this.dataGridViewTextBoxColumn1.HeaderText = "HallID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Capacity";
            this.dataGridViewTextBoxColumn2.HeaderText = "Capacity";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Availability";
            this.dataGridViewTextBoxColumn3.HeaderText = "Availability";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1058, 605);
            this.Controls.Add(this.panelDelete);
            this.Controls.Add(this.panelEdit);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.btnDeleteHall);
            this.Controls.Add(this.btnEditHall);
            this.Controls.Add(this.btnAddHalls);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "ManagerHalls";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hallsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_DatabaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hallsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hallsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_DatabaseDataSet)).EndInit();
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            this.panelDelete.ResumeLayout(false);
            this.panelDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_DatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_DatabaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hallsBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddHalls;
        private System.Windows.Forms.Button btnEditHall;
        private System.Windows.Forms.Button btnDeleteHall;
        private IOOP_DatabaseDataSet iOOP_DatabaseDataSet;
        private System.Windows.Forms.BindingSource hallsBindingSource;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Panel panelDelete;
        private System.Windows.Forms.TextBox txtCapacity1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHallID1;
        private System.Windows.Forms.Label lblHallID1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHallID3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSaveAdd;
        private System.Windows.Forms.ComboBox comboAvailability1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboAvailability2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCapacity2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSaveEdit;
        private System.Windows.Forms.Button btnSaveDelete;
        private IOOP_DatabaseDataSet1 iOOP_DatabaseDataSet1;
        private System.Windows.Forms.BindingSource hallsBindingSource1;
        private System.Windows.Forms.TextBox txtHallID2;
        private System.Windows.Forms.BindingSource hallsBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn hallIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availabilityDataGridViewTextBoxColumn;
        private IOOP_DatabaseDataSet2 iOOP_DatabaseDataSet2;
        private System.Windows.Forms.BindingSource hallsBindingSource3;
        private IOOP_DatabaseDataSet2TableAdapters.HallsTableAdapter hallsTableAdapter;
        private IOOP_DatabaseDataSet3 iOOP_DatabaseDataSet3;
        private System.Windows.Forms.BindingSource hallsBindingSource4;
        private IOOP_DatabaseDataSet3TableAdapters.HallsTableAdapter hallsTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}