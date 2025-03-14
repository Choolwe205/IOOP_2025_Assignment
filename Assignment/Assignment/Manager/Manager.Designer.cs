namespace Assignment.Manager
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.label1 = new System.Windows.Forms.Label();
            this.btnManageMenu = new System.Windows.Forms.Button();
            this.btnManageHalls = new System.Windows.Forms.Button();
            this.btnViewReservations = new System.Windows.Forms.Button();
            this.btnHallReport = new System.Windows.Forms.Button();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(454, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manager";
            // 
            // btnManageMenu
            // 
            this.btnManageMenu.BackColor = System.Drawing.Color.DarkOrange;
            this.btnManageMenu.Location = new System.Drawing.Point(59, 318);
            this.btnManageMenu.Name = "btnManageMenu";
            this.btnManageMenu.Size = new System.Drawing.Size(233, 93);
            this.btnManageMenu.TabIndex = 1;
            this.btnManageMenu.Text = "Manage Menu";
            this.btnManageMenu.UseVisualStyleBackColor = false;
            // 
            // btnManageHalls
            // 
            this.btnManageHalls.BackColor = System.Drawing.Color.DarkOrange;
            this.btnManageHalls.Location = new System.Drawing.Point(426, 318);
            this.btnManageHalls.Name = "btnManageHalls";
            this.btnManageHalls.Size = new System.Drawing.Size(233, 93);
            this.btnManageHalls.TabIndex = 2;
            this.btnManageHalls.Text = "Manage Halls";
            this.btnManageHalls.UseVisualStyleBackColor = false;
            // 
            // btnViewReservations
            // 
            this.btnViewReservations.BackColor = System.Drawing.Color.DarkOrange;
            this.btnViewReservations.Location = new System.Drawing.Point(774, 318);
            this.btnViewReservations.Name = "btnViewReservations";
            this.btnViewReservations.Size = new System.Drawing.Size(233, 93);
            this.btnViewReservations.TabIndex = 3;
            this.btnViewReservations.Text = "View Past Reservations";
            this.btnViewReservations.UseVisualStyleBackColor = false;
            // 
            // btnHallReport
            // 
            this.btnHallReport.BackColor = System.Drawing.Color.DarkOrange;
            this.btnHallReport.Location = new System.Drawing.Point(238, 479);
            this.btnHallReport.Name = "btnHallReport";
            this.btnHallReport.Size = new System.Drawing.Size(233, 93);
            this.btnHallReport.TabIndex = 4;
            this.btnHallReport.Text = "View Reservation Hall Report";
            this.btnHallReport.UseVisualStyleBackColor = false;
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUpdateProfile.Location = new System.Drawing.Point(599, 479);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(233, 93);
            this.btnUpdateProfile.TabIndex = 5;
            this.btnUpdateProfile.Text = "Update Own Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = false;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1068, 696);
            this.Controls.Add(this.btnUpdateProfile);
            this.Controls.Add(this.btnHallReport);
            this.Controls.Add(this.btnViewReservations);
            this.Controls.Add(this.btnManageHalls);
            this.Controls.Add(this.btnManageMenu);
            this.Controls.Add(this.label1);
            this.Name = "Manager";
            this.Text = "ManagerDashboard";
            this.Load += new System.EventHandler(this.Manager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnManageMenu;
        private System.Windows.Forms.Button btnManageHalls;
        private System.Windows.Forms.Button btnViewReservations;
        private System.Windows.Forms.Button btnHallReport;
        private System.Windows.Forms.Button btnUpdateProfile;
    }
}