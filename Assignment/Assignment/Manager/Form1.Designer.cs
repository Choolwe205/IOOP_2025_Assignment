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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iOOP_DatabaseDataSet10 = new Assignment.IOOP_DatabaseDataSet10();
            this.resrvationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resrvationsTableAdapter = new Assignment.IOOP_DatabaseDataSet10TableAdapters.ResrvationsTableAdapter();
            this.reservationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hallIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlReservationReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_DatabaseDataSet10)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reservationIDDataGridViewTextBoxColumn,
            this.hallIDDataGridViewTextBoxColumn,
            this.reservationTypeDataGridViewTextBoxColumn,
            this.bookingDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.resrvationsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(475, 193);
            this.dataGridView1.TabIndex = 1;
            // 
            // iOOP_DatabaseDataSet10
            // 
            this.iOOP_DatabaseDataSet10.DataSetName = "IOOP_DatabaseDataSet10";
            this.iOOP_DatabaseDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resrvationsBindingSource
            // 
            this.resrvationsBindingSource.DataMember = "Resrvations";
            this.resrvationsBindingSource.DataSource = this.iOOP_DatabaseDataSet10;
            // 
            // resrvationsTableAdapter
            // 
            this.resrvationsTableAdapter.ClearBeforeFill = true;
            // 
            // reservationIDDataGridViewTextBoxColumn
            // 
            this.reservationIDDataGridViewTextBoxColumn.DataPropertyName = "Reservation ID";
            this.reservationIDDataGridViewTextBoxColumn.HeaderText = "Reservation ID";
            this.reservationIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reservationIDDataGridViewTextBoxColumn.Name = "reservationIDDataGridViewTextBoxColumn";
            this.reservationIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.reservationIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // hallIDDataGridViewTextBoxColumn
            // 
            this.hallIDDataGridViewTextBoxColumn.DataPropertyName = "Hall ID";
            this.hallIDDataGridViewTextBoxColumn.HeaderText = "Hall ID";
            this.hallIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hallIDDataGridViewTextBoxColumn.Name = "hallIDDataGridViewTextBoxColumn";
            this.hallIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.hallIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // reservationTypeDataGridViewTextBoxColumn
            // 
            this.reservationTypeDataGridViewTextBoxColumn.DataPropertyName = "Reservation Type";
            this.reservationTypeDataGridViewTextBoxColumn.HeaderText = "Reservation Type";
            this.reservationTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reservationTypeDataGridViewTextBoxColumn.Name = "reservationTypeDataGridViewTextBoxColumn";
            this.reservationTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.reservationTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookingDateDataGridViewTextBoxColumn
            // 
            this.bookingDateDataGridViewTextBoxColumn.DataPropertyName = "Booking Date";
            this.bookingDateDataGridViewTextBoxColumn.HeaderText = "Booking Date";
            this.bookingDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookingDateDataGridViewTextBoxColumn.Name = "bookingDateDataGridViewTextBoxColumn";
            this.bookingDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookingDateDataGridViewTextBoxColumn.Width = 125;
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
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_DatabaseDataSet10)).EndInit();
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
        private IOOP_DatabaseDataSet10 iOOP_DatabaseDataSet10;
        private System.Windows.Forms.BindingSource resrvationsBindingSource;
        private IOOP_DatabaseDataSet10TableAdapters.ResrvationsTableAdapter resrvationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hallIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnClose;
    }
}