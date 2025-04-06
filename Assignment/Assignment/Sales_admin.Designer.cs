namespace Assignment
{
    partial class Sales_admin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.chef_lbl = new System.Windows.Forms.Label();
            this.chef_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.orders_number = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SalesDisplay_lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chef_lbl);
            this.panel1.Controls.Add(this.chef_btn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.orders_number);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SalesDisplay_lbl);
            this.panel1.Location = new System.Drawing.Point(40, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 406);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // chef_lbl
            // 
            this.chef_lbl.AutoSize = true;
            this.chef_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chef_lbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chef_lbl.Location = new System.Drawing.Point(206, 309);
            this.chef_lbl.Name = "chef_lbl";
            this.chef_lbl.Size = new System.Drawing.Size(36, 38);
            this.chef_lbl.TabIndex = 17;
            this.chef_lbl.Text = "0";
            this.chef_lbl.Click += new System.EventHandler(this.chef_lbl_Click);
            // 
            // chef_btn
            // 
            this.chef_btn.BackColor = System.Drawing.Color.OrangeRed;
            this.chef_btn.FlatAppearance.BorderSize = 0;
            this.chef_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chef_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chef_btn.Location = new System.Drawing.Point(497, 243);
            this.chef_btn.Name = "chef_btn";
            this.chef_btn.Size = new System.Drawing.Size(26, 30);
            this.chef_btn.TabIndex = 16;
            this.chef_btn.Text = "+";
            this.chef_btn.UseVisualStyleBackColor = false;
            this.chef_btn.Click += new System.EventHandler(this.chef_btn_Click);
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(73, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Chef Sales: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(213, 250);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 22);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // orders_number
            // 
            this.orders_number.AutoSize = true;
            this.orders_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_number.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.orders_number.Location = new System.Drawing.Point(206, 155);
            this.orders_number.Name = "orders_number";
            this.orders_number.Size = new System.Drawing.Size(36, 38);
            this.orders_number.TabIndex = 13;
            this.orders_number.Text = "0";
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(31, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Number Of Orders: ";
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(73, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Monthly Sale: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(130, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Monthly Sales";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SalesDisplay_lbl
            // 
            this.SalesDisplay_lbl.AutoSize = true;
            this.SalesDisplay_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesDisplay_lbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SalesDisplay_lbl.Location = new System.Drawing.Point(206, 69);
            this.SalesDisplay_lbl.Name = "SalesDisplay_lbl";
            this.SalesDisplay_lbl.Size = new System.Drawing.Size(36, 38);
            this.SalesDisplay_lbl.TabIndex = 4;
            this.SalesDisplay_lbl.Text = "0";
            this.SalesDisplay_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // Sales_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1146, 650);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sales_admin";
            this.Text = "Sales_admin";
            this.Load += new System.EventHandler(this.Sales_admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SalesDisplay_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label orders_number;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label chef_lbl;
        private System.Windows.Forms.Button chef_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
    }
}