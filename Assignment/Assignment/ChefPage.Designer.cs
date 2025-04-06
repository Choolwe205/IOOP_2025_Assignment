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
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.btnIngredients = new System.Windows.Forms.Button();
            this.lblChef = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.Location = new System.Drawing.Point(161, 282);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(164, 83);
            this.btnViewOrders.TabIndex = 0;
            this.btnViewOrders.Text = "View Orders";
            this.btnViewOrders.UseVisualStyleBackColor = true;
            this.btnViewOrders.Click += new System.EventHandler(this.btnViewOrders_Click);
            // 
            // btnIngredients
            // 
            this.btnIngredients.Location = new System.Drawing.Point(409, 282);
            this.btnIngredients.Name = "btnIngredients";
            this.btnIngredients.Size = new System.Drawing.Size(164, 83);
            this.btnIngredients.TabIndex = 1;
            this.btnIngredients.Text = "Manage Ingredients";
            this.btnIngredients.UseVisualStyleBackColor = true;
            this.btnIngredients.Click += new System.EventHandler(this.btnIngredients_Click);
            // 
            // lblChef
            // 
            this.lblChef.AutoSize = true;
            this.lblChef.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChef.Location = new System.Drawing.Point(318, 129);
            this.lblChef.Name = "lblChef";
            this.lblChef.Size = new System.Drawing.Size(101, 42);
            this.lblChef.TabIndex = 2;
            this.lblChef.Text = "Chef";
            // 
            // ChefPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblChef);
            this.Controls.Add(this.btnIngredients);
            this.Controls.Add(this.btnViewOrders);
            this.Name = "ChefPage";
            this.Text = "ChefPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.Button btnIngredients;
        private System.Windows.Forms.Label lblChef;
    }
}