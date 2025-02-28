namespace Classespractice
{
    partial class Customer_Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMalaysianMenu = new System.Windows.Forms.Button();
            this.btnWesternMenu = new System.Windows.Forms.Button();
            this.btnChineseMenu = new System.Windows.Forms.Button();
            this.btnIndianMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SandyBrown;
            this.label1.Location = new System.Drawing.Point(331, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // btnMalaysianMenu
            // 
            this.btnMalaysianMenu.BackColor = System.Drawing.Color.SandyBrown;
            this.btnMalaysianMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMalaysianMenu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnMalaysianMenu.Location = new System.Drawing.Point(176, 168);
            this.btnMalaysianMenu.Name = "btnMalaysianMenu";
            this.btnMalaysianMenu.Size = new System.Drawing.Size(154, 54);
            this.btnMalaysianMenu.TabIndex = 2;
            this.btnMalaysianMenu.Text = "Malaysian";
            this.btnMalaysianMenu.UseVisualStyleBackColor = false;
            this.btnMalaysianMenu.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // btnWesternMenu
            // 
            this.btnWesternMenu.BackColor = System.Drawing.Color.SandyBrown;
            this.btnWesternMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWesternMenu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnWesternMenu.Location = new System.Drawing.Point(427, 168);
            this.btnWesternMenu.Name = "btnWesternMenu";
            this.btnWesternMenu.Size = new System.Drawing.Size(154, 54);
            this.btnWesternMenu.TabIndex = 3;
            this.btnWesternMenu.Text = "Western";
            this.btnWesternMenu.UseVisualStyleBackColor = false;
            this.btnWesternMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnChineseMenu
            // 
            this.btnChineseMenu.BackColor = System.Drawing.Color.SandyBrown;
            this.btnChineseMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChineseMenu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnChineseMenu.Location = new System.Drawing.Point(427, 290);
            this.btnChineseMenu.Name = "btnChineseMenu";
            this.btnChineseMenu.Size = new System.Drawing.Size(154, 54);
            this.btnChineseMenu.TabIndex = 4;
            this.btnChineseMenu.Text = "Chinese";
            this.btnChineseMenu.UseVisualStyleBackColor = false;
            this.btnChineseMenu.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnIndianMenu
            // 
            this.btnIndianMenu.BackColor = System.Drawing.Color.SandyBrown;
            this.btnIndianMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndianMenu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnIndianMenu.Location = new System.Drawing.Point(176, 290);
            this.btnIndianMenu.Name = "btnIndianMenu";
            this.btnIndianMenu.Size = new System.Drawing.Size(154, 54);
            this.btnIndianMenu.TabIndex = 5;
            this.btnIndianMenu.Text = "Indian";
            this.btnIndianMenu.UseVisualStyleBackColor = false;
            this.btnIndianMenu.Click += new System.EventHandler(this.button3_Click);
            // 
            // Customer_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIndianMenu);
            this.Controls.Add(this.btnChineseMenu);
            this.Controls.Add(this.btnWesternMenu);
            this.Controls.Add(this.btnMalaysianMenu);
            this.Controls.Add(this.label1);
            this.Name = "Customer_Menu";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMalaysianMenu;
        private System.Windows.Forms.Button btnWesternMenu;
        private System.Windows.Forms.Button btnChineseMenu;
        private System.Windows.Forms.Button btnIndianMenu;
    }
}