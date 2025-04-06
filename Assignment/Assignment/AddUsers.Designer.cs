namespace Assignment
{
    partial class AddUsers
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
            this.phone_number_txtbox = new System.Windows.Forms.TextBox();
            this.password_txtbox = new System.Windows.Forms.TextBox();
            this.name_txtbox = new System.Windows.Forms.TextBox();
            this.role_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Email_txtbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Add_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // phone_number_txtbox
            // 
            this.phone_number_txtbox.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.phone_number_txtbox.Location = new System.Drawing.Point(419, 338);
            this.phone_number_txtbox.Name = "phone_number_txtbox";
            this.phone_number_txtbox.Size = new System.Drawing.Size(281, 22);
            this.phone_number_txtbox.TabIndex = 28;
            this.phone_number_txtbox.UseWaitCursor = true;
            this.phone_number_txtbox.TextChanged += new System.EventHandler(this.phone_number_txtbox_TextChanged);
            // 
            // password_txtbox
            // 
            this.password_txtbox.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.password_txtbox.Location = new System.Drawing.Point(419, 267);
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.Size = new System.Drawing.Size(281, 22);
            this.password_txtbox.TabIndex = 27;
            this.password_txtbox.UseWaitCursor = true;
            this.password_txtbox.TextChanged += new System.EventHandler(this.password_txtbox_TextChanged);
            // 
            // name_txtbox
            // 
            this.name_txtbox.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.name_txtbox.Location = new System.Drawing.Point(419, 206);
            this.name_txtbox.Name = "name_txtbox";
            this.name_txtbox.Size = new System.Drawing.Size(281, 22);
            this.name_txtbox.TabIndex = 26;
            this.name_txtbox.UseWaitCursor = true;
            this.name_txtbox.TextChanged += new System.EventHandler(this.name_txtbox_TextChanged);
            // 
            // role_lbl
            // 
            this.role_lbl.AutoSize = true;
            this.role_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.role_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.role_lbl.Location = new System.Drawing.Point(443, 49);
            this.role_lbl.Name = "role_lbl";
            this.role_lbl.Size = new System.Drawing.Size(96, 32);
            this.role_lbl.TabIndex = 21;
            this.role_lbl.Text = "labels";
            this.role_lbl.UseWaitCursor = true;
            this.role_lbl.Click += new System.EventHandler(this.role_lbl_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(306, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Password:";
            this.label3.UseWaitCursor = true;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(256, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Phone Number:";
            this.label2.UseWaitCursor = true;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(334, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Name: ";
            this.label4.UseWaitCursor = true;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Email_txtbox
            // 
            this.Email_txtbox.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Email_txtbox.Location = new System.Drawing.Point(419, 139);
            this.Email_txtbox.Name = "Email_txtbox";
            this.Email_txtbox.Size = new System.Drawing.Size(281, 22);
            this.Email_txtbox.TabIndex = 32;
            this.Email_txtbox.UseWaitCursor = true;
            this.Email_txtbox.TextChanged += new System.EventHandler(this.Email_txtbox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(310, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Email ID: ";
            this.label6.UseWaitCursor = true;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Add_btn
            // 
            this.Add_btn.BackColor = System.Drawing.Color.OrangeRed;
            this.Add_btn.FlatAppearance.BorderSize = 0;
            this.Add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Add_btn.Location = new System.Drawing.Point(419, 431);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(146, 53);
            this.Add_btn.TabIndex = 33;
            this.Add_btn.Text = "Add";
            this.Add_btn.UseVisualStyleBackColor = false;
            this.Add_btn.UseWaitCursor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // AddUsers
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1119, 588);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.Email_txtbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.phone_number_txtbox);
            this.Controls.Add(this.password_txtbox);
            this.Controls.Add(this.name_txtbox);
            this.Controls.Add(this.role_lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddUsers";
            this.Text = "AddUsers";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.AddUsers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox phone_number_txtbox;
        private System.Windows.Forms.TextBox password_txtbox;
        private System.Windows.Forms.TextBox name_txtbox;
        private System.Windows.Forms.Label role_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Email_txtbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Add_btn;
    }
}