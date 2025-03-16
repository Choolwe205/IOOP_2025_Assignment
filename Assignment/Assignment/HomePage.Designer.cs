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
            this.btnCustomerReq = new System.Windows.Forms.Button();
            this.btnHall = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(492, 209);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(179, 29);
            this.btnProfile.TabIndex = 9;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            // 
            // btnCustomerReq
            // 
            this.btnCustomerReq.Location = new System.Drawing.Point(492, 150);
            this.btnCustomerReq.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCustomerReq.Name = "btnCustomerReq";
            this.btnCustomerReq.Size = new System.Drawing.Size(179, 29);
            this.btnCustomerReq.TabIndex = 8;
            this.btnCustomerReq.Text = "Customer Request";
            this.btnCustomerReq.UseVisualStyleBackColor = true;
            // 
            // btnHall
            // 
            this.btnHall.Location = new System.Drawing.Point(130, 271);
            this.btnHall.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHall.Name = "btnHall";
            this.btnHall.Size = new System.Drawing.Size(159, 29);
            this.btnHall.TabIndex = 7;
            this.btnHall.Text = "Assign Hall";
            this.btnHall.UseVisualStyleBackColor = true;
            // 
            // btnManage
            // 
            this.btnManage.Location = new System.Drawing.Point(130, 209);
            this.btnManage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(159, 29);
            this.btnManage.TabIndex = 6;
            this.btnManage.Text = "Manage Reservation";
            this.btnManage.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(130, 150);
            this.btnView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(159, 29);
            this.btnView.TabIndex = 5;
            this.btnView.Text = "View Reservation";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // Main_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnCustomerReq);
            this.Controls.Add(this.btnHall);
            this.Controls.Add(this.btnManage);
            this.Controls.Add(this.btnView);
            this.Name = "Main_Dashboard";
            this.Text = "HomePage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnCustomerReq;
        private System.Windows.Forms.Button btnHall;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Button btnView;
    }
}