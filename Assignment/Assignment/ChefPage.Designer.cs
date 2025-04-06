namespace Assignment
{
    partial class ChefPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChefPage));
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.btnIngredients = new System.Windows.Forms.Button();
            this.lblChef = new System.Windows.Forms.Label();
            this.btnChefViewProfile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnViewOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btnViewOrders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewOrders.Location = new System.Drawing.Point(47, 346);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(164, 98);
            this.btnViewOrders.TabIndex = 0;
            this.btnViewOrders.Text = "View Orders";
            this.btnViewOrders.UseVisualStyleBackColor = false;
            this.btnViewOrders.Click += new System.EventHandler(this.btnViewOrders_Click);
            // 
            // btnIngredients
            // 
            this.btnIngredients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIngredients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btnIngredients.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIngredients.Location = new System.Drawing.Point(534, 346);
            this.btnIngredients.Name = "btnIngredients";
            this.btnIngredients.Size = new System.Drawing.Size(164, 98);
            this.btnIngredients.TabIndex = 1;
            this.btnIngredients.Text = "Manage Ingredients";
            this.btnIngredients.UseVisualStyleBackColor = false;
            this.btnIngredients.Click += new System.EventHandler(this.btnIngredients_Click);
            // 
            // lblChef
            // 
            this.lblChef.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblChef.AutoSize = true;
            this.lblChef.BackColor = System.Drawing.Color.Transparent;
            this.lblChef.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChef.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.lblChef.Location = new System.Drawing.Point(318, 154);
            this.lblChef.Name = "lblChef";
            this.lblChef.Size = new System.Drawing.Size(108, 50);
            this.lblChef.TabIndex = 2;
            this.lblChef.Text = "Chef";
            // 
            // btnChefViewProfile
            // 
            this.btnChefViewProfile.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnChefViewProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btnChefViewProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChefViewProfile.Location = new System.Drawing.Point(283, 346);
            this.btnChefViewProfile.Name = "btnChefViewProfile";
            this.btnChefViewProfile.Size = new System.Drawing.Size(164, 98);
            this.btnChefViewProfile.TabIndex = 3;
            this.btnChefViewProfile.Text = "View Profile";
            this.btnChefViewProfile.UseVisualStyleBackColor = false;
            this.btnChefViewProfile.Click += new System.EventHandler(this.btnChefViewProfile_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(534, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 98);
            this.button1.TabIndex = 4;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChefPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(767, 484);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnChefViewProfile);
            this.Controls.Add(this.lblChef);
            this.Controls.Add(this.btnIngredients);
            this.Controls.Add(this.btnViewOrders);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ChefPage";
            this.Text = "ChefPage";
            this.Load += new System.EventHandler(this.ChefPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.Button btnIngredients;
        private System.Windows.Forms.Label lblChef;
        private System.Windows.Forms.Button btnChefViewProfile;
        private System.Windows.Forms.Button button1;
    }
}