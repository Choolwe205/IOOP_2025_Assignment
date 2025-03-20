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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnManageMenu = new System.Windows.Forms.Button();
            this.btnManageHalls = new System.Windows.Forms.Button();
            this.btnPastReservations = new System.Windows.Forms.Button();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.btnHallReport = new System.Windows.Forms.Button();
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
            // 
            // btnPastReservations
            // 
            this.btnPastReservations.BackColor = System.Drawing.Color.DarkOrange;
            this.btnPastReservations.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPastReservations.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnPastReservations.Location = new System.Drawing.Point(603, 262);
            this.btnPastReservations.Name = "btnPastReservations";
            this.btnPastReservations.Size = new System.Drawing.Size(163, 78);
            this.btnPastReservations.TabIndex = 3;
            this.btnPastReservations.Text = "View Past Reservations";
            this.btnPastReservations.UseVisualStyleBackColor = false;
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
            this.btnHallReport.Location = new System.Drawing.Point(466, 418);
            this.btnHallReport.Name = "btnHallReport";
            this.btnHallReport.Size = new System.Drawing.Size(178, 106);
            this.btnHallReport.TabIndex = 5;
            this.btnHallReport.Text = "View Reservation Hall Report";
            this.btnHallReport.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1110, 705);
            this.Controls.Add(this.btnHallReport);
            this.Controls.Add(this.btnUpdateProfile);
            this.Controls.Add(this.btnPastReservations);
            this.Controls.Add(this.btnManageHalls);
            this.Controls.Add(this.btnManageMenu);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ManagerDashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnManageMenu;
        private System.Windows.Forms.Button btnManageHalls;
        private System.Windows.Forms.Button btnPastReservations;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.Button btnHallReport;
    }
}