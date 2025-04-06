namespace Assignment
{
    partial class Main_Dashboard
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
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.OrangeRed;
            this.btnProfile.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnProfile.Location = new System.Drawing.Point(477, 103);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(179, 86);
            this.btnProfile.TabIndex = 9;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            // 
            // btnManage
            // 
            this.btnManage.BackColor = System.Drawing.Color.OrangeRed;
            this.btnManage.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnManage.Location = new System.Drawing.Point(130, 239);
            this.btnManage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(196, 88);
            this.btnManage.TabIndex = 6;
            this.btnManage.Text = "Manage Reservation";
            this.btnManage.UseVisualStyleBackColor = false;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.OrangeRed;
            this.btnView.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnView.Location = new System.Drawing.Point(130, 103);
            this.btnView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(196, 88);
            this.btnView.TabIndex = 5;
            this.btnView.Text = "View requests";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.OrangeRed;
            this.btnlogout.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnlogout.Location = new System.Drawing.Point(477, 239);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(179, 88);
            this.btnlogout.TabIndex = 10;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // Main_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment.Properties.Resources.cover;
            this.ClientSize = new System.Drawing.Size(1133, 751);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnManage);
            this.Controls.Add(this.btnView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main_Dashboard";
            this.Text = "Reservation Coordinator HomePage";
            this.Load += new System.EventHandler(this.Main_Dashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnlogout;
    }
}