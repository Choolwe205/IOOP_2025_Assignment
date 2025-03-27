namespace Assignment.Manager
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnManageMenu = new System.Windows.Forms.Button();
            this.btnManageHalls = new System.Windows.Forms.Button();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.btnHallReport = new System.Windows.Forms.Button();
            this.pnlReservationReport = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resrvationsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iOOP_DatabaseDataSet1 = new Assignment.IOOP_DatabaseDataSet1();
            this.label2 = new System.Windows.Forms.Label();
            this.resrvationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resrvationsTableAdapter = new Assignment.IOOP_DatabaseDataSet1TableAdapters.ResrvationsTableAdapter();
            this.pnlReservationReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resrvationsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_DatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resrvationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(475, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manager";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnManageMenu
            // 
            this.btnManageMenu.BackColor = System.Drawing.Color.DarkOrange;
            this.btnManageMenu.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageMenu.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnManageMenu.Location = new System.Drawing.Point(95, 262);
            this.btnManageMenu.Name = "btnManageMenu";
            this.btnManageMenu.Size = new System.Drawing.Size(163, 78);
            this.btnManageMenu.TabIndex = 1;
            this.btnManageMenu.Text = "Manage Menu";
            this.btnManageMenu.UseVisualStyleBackColor = false;
            this.btnManageMenu.Click += new System.EventHandler(this.btnManageMenu_Click);
            // 
            // btnManageHalls
            // 
            this.btnManageHalls.BackColor = System.Drawing.Color.DarkOrange;
            this.btnManageHalls.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageHalls.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnManageHalls.Location = new System.Drawing.Point(351, 262);
            this.btnManageHalls.Name = "btnManageHalls";
            this.btnManageHalls.Size = new System.Drawing.Size(163, 78);
            this.btnManageHalls.TabIndex = 2;
            this.btnManageHalls.Text = "Manage Halls";
            this.btnManageHalls.UseVisualStyleBackColor = false;
            this.btnManageHalls.Click += new System.EventHandler(this.btnManageHalls_Click);
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUpdateProfile.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProfile.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnUpdateProfile.Location = new System.Drawing.Point(846, 262);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(163, 78);
            this.btnUpdateProfile.TabIndex = 4;
            this.btnUpdateProfile.Text = "Update Own Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = false;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);
            // 
            // btnHallReport
            // 
            this.btnHallReport.BackColor = System.Drawing.Color.DarkOrange;
            this.btnHallReport.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHallReport.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnHallReport.Location = new System.Drawing.Point(591, 262);
            this.btnHallReport.Name = "btnHallReport";
            this.btnHallReport.Size = new System.Drawing.Size(178, 106);
            this.btnHallReport.TabIndex = 5;
            this.btnHallReport.Text = "View Reservation Hall Report";
            this.btnHallReport.UseVisualStyleBackColor = false;
            this.btnHallReport.Click += new System.EventHandler(this.btnHallReport_Click);
            // 
            // pnlReservationReport
            // 
            this.pnlReservationReport.BackColor = System.Drawing.Color.DarkOrange;
            this.pnlReservationReport.Controls.Add(this.btnClose);
            this.pnlReservationReport.Controls.Add(this.dataGridView1);
            this.pnlReservationReport.Controls.Add(this.label2);
            this.pnlReservationReport.Location = new System.Drawing.Point(44, 107);
            this.pnlReservationReport.Name = "pnlReservationReport";
            this.pnlReservationReport.Size = new System.Drawing.Size(481, 395);
            this.pnlReservationReport.TabIndex = 6;
            this.pnlReservationReport.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(199, 316);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView1.DataSource = this.resrvationsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(3, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(475, 193);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Reservation ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Reservation ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Hall ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Hall ID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Reservation Type";
            this.dataGridViewTextBoxColumn3.HeaderText = "Reservation Type";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Booking Date";
            this.dataGridViewTextBoxColumn4.HeaderText = "Booking Date";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // resrvationsBindingSource1
            // 
            this.resrvationsBindingSource1.DataMember = "Resrvations";
            this.resrvationsBindingSource1.DataSource = this.iOOP_DatabaseDataSet1;
            // 
            // iOOP_DatabaseDataSet1
            // 
            this.iOOP_DatabaseDataSet1.DataSetName = "IOOP_DatabaseDataSet1";
            this.iOOP_DatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(147, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Reservation Hall Report";
            // 
            // resrvationsBindingSource
            // 
            this.resrvationsBindingSource.DataMember = "Resrvations";
            // 
            // resrvationsTableAdapter
            // 
            this.resrvationsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1110, 705);
            this.Controls.Add(this.pnlReservationReport);
            this.Controls.Add(this.btnHallReport);
            this.Controls.Add(this.btnUpdateProfile);
            this.Controls.Add(this.btnManageHalls);
            this.Controls.Add(this.btnManageMenu);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ManagerDashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlReservationReport.ResumeLayout(false);
            this.pnlReservationReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resrvationsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_DatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resrvationsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnManageMenu;
        private System.Windows.Forms.Button btnManageHalls;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.Button btnHallReport;
        private System.Windows.Forms.Panel pnlReservationReport;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource resrvationsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hallIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnClose;
        private IOOP_DatabaseDataSet1 iOOP_DatabaseDataSet1;
        private System.Windows.Forms.BindingSource resrvationsBindingSource1;
        private IOOP_DatabaseDataSet1TableAdapters.ResrvationsTableAdapter resrvationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}