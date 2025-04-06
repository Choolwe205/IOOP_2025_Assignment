namespace Assignment
{
    partial class Admin_users
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_users));
            this.username_lbl = new System.Windows.Forms.Label();
            this.Edit_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.username_lbl.Location = new System.Drawing.Point(160, 43);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(128, 29);
            this.username_lbl.TabIndex = 0;
            this.username_lbl.Text = "username";
            // 
            // Edit_btn
            // 
            this.Edit_btn.BackColor = System.Drawing.Color.OrangeRed;
            this.Edit_btn.FlatAppearance.BorderSize = 0;
            this.Edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Edit_btn.Location = new System.Drawing.Point(623, 22);
            this.Edit_btn.Name = "Edit_btn";
            this.Edit_btn.Size = new System.Drawing.Size(136, 32);
            this.Edit_btn.TabIndex = 2;
            this.Edit_btn.Text = "Edit";
            this.Edit_btn.UseVisualStyleBackColor = false;
            this.Edit_btn.Click += new System.EventHandler(this.Edit_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.OrangeRed;
            this.delete_btn.FlatAppearance.BorderSize = 0;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete_btn.Location = new System.Drawing.Point(623, 60);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(136, 32);
            this.delete_btn.TabIndex = 3;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 110);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Admin_users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.Edit_btn);
            this.Controls.Add(this.username_lbl);
            this.Name = "Admin_users";
            this.Size = new System.Drawing.Size(852, 117);
            this.Load += new System.EventHandler(this.Admin_users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.Button Edit_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
