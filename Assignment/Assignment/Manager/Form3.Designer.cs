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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewHalls = new System.Windows.Forms.Button();
            this.btnAddHalls = new System.Windows.Forms.Button();
            this.btnEditHall = new System.Windows.Forms.Button();
            this.btnDeleteHall = new System.Windows.Forms.Button();
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
            // btnViewHalls
            // 
            this.btnViewHalls.BackColor = System.Drawing.Color.DarkOrange;
            this.btnViewHalls.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewHalls.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnViewHalls.Location = new System.Drawing.Point(111, 305);
            this.btnViewHalls.Name = "btnViewHalls";
            this.btnViewHalls.Size = new System.Drawing.Size(167, 77);
            this.btnViewHalls.TabIndex = 1;
            this.btnViewHalls.Text = "View Halls";
            this.btnViewHalls.UseVisualStyleBackColor = false;
            // 
            // btnAddHalls
            // 
            this.btnAddHalls.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAddHalls.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHalls.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAddHalls.Location = new System.Drawing.Point(348, 305);
            this.btnAddHalls.Name = "btnAddHalls";
            this.btnAddHalls.Size = new System.Drawing.Size(167, 77);
            this.btnAddHalls.TabIndex = 2;
            this.btnAddHalls.Text = "Add New Hall";
            this.btnAddHalls.UseVisualStyleBackColor = false;
            // 
            // btnEditHall
            // 
            this.btnEditHall.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEditHall.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditHall.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnEditHall.Location = new System.Drawing.Point(589, 305);
            this.btnEditHall.Name = "btnEditHall";
            this.btnEditHall.Size = new System.Drawing.Size(167, 77);
            this.btnEditHall.TabIndex = 3;
            this.btnEditHall.Text = "Edit Hall";
            this.btnEditHall.UseVisualStyleBackColor = false;
            // 
            // btnDeleteHall
            // 
            this.btnDeleteHall.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDeleteHall.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteHall.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnDeleteHall.Location = new System.Drawing.Point(819, 305);
            this.btnDeleteHall.Name = "btnDeleteHall";
            this.btnDeleteHall.Size = new System.Drawing.Size(167, 77);
            this.btnDeleteHall.TabIndex = 4;
            this.btnDeleteHall.Text = "Delete Hall";
            this.btnDeleteHall.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1099, 760);
            this.Controls.Add(this.btnDeleteHall);
            this.Controls.Add(this.btnEditHall);
            this.Controls.Add(this.btnAddHalls);
            this.Controls.Add(this.btnViewHalls);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "ManagerHalls";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewHalls;
        private System.Windows.Forms.Button btnAddHalls;
        private System.Windows.Forms.Button btnEditHall;
        private System.Windows.Forms.Button btnDeleteHall;
    }
}