namespace Assignment
{
    partial class ChefIngredients
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grboxModifyIngredients = new System.Windows.Forms.GroupBox();
            this.lblIngredientID = new System.Windows.Forms.Label();
            this.lblIngredient = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnAddIngredient = new System.Windows.Forms.Button();
            this.btnModifyIngredient = new System.Windows.Forms.Button();
            this.txtIngredientID = new System.Windows.Forms.TextBox();
            this.txtIngredient = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grboxModifyIngredients.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(397, 223);
            this.dataGridView1.TabIndex = 0;
            // 
            // grboxModifyIngredients
            // 
            this.grboxModifyIngredients.Controls.Add(this.txtQuantity);
            this.grboxModifyIngredients.Controls.Add(this.txtIngredient);
            this.grboxModifyIngredients.Controls.Add(this.txtIngredientID);
            this.grboxModifyIngredients.Controls.Add(this.btnModifyIngredient);
            this.grboxModifyIngredients.Controls.Add(this.btnAddIngredient);
            this.grboxModifyIngredients.Controls.Add(this.lblQuantity);
            this.grboxModifyIngredients.Controls.Add(this.lblIngredient);
            this.grboxModifyIngredients.Controls.Add(this.lblIngredientID);
            this.grboxModifyIngredients.Location = new System.Drawing.Point(453, 35);
            this.grboxModifyIngredients.Name = "grboxModifyIngredients";
            this.grboxModifyIngredients.Size = new System.Drawing.Size(314, 226);
            this.grboxModifyIngredients.TabIndex = 1;
            this.grboxModifyIngredients.TabStop = false;
            this.grboxModifyIngredients.Text = "Modify Ingredients";
            // 
            // lblIngredientID
            // 
            this.lblIngredientID.AutoSize = true;
            this.lblIngredientID.Location = new System.Drawing.Point(-3, 39);
            this.lblIngredientID.Name = "lblIngredientID";
            this.lblIngredientID.Size = new System.Drawing.Size(85, 16);
            this.lblIngredientID.TabIndex = 0;
            this.lblIngredientID.Text = "Ingredient ID:";
            this.lblIngredientID.Click += new System.EventHandler(this.lblIngredientID_Click);
            // 
            // lblIngredient
            // 
            this.lblIngredient.AutoSize = true;
            this.lblIngredient.Location = new System.Drawing.Point(10, 80);
            this.lblIngredient.Name = "lblIngredient";
            this.lblIngredient.Size = new System.Drawing.Size(69, 16);
            this.lblIngredient.TabIndex = 1;
            this.lblIngredient.Text = "Ingredient:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(21, 122);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(58, 16);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Quantity:";
            this.lblQuantity.Click += new System.EventHandler(this.lblQuantity_Click);
            // 
            // btnAddIngredient
            // 
            this.btnAddIngredient.Location = new System.Drawing.Point(64, 174);
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Size = new System.Drawing.Size(75, 23);
            this.btnAddIngredient.TabIndex = 3;
            this.btnAddIngredient.Text = "Add";
            this.btnAddIngredient.UseVisualStyleBackColor = true;
            // 
            // btnModifyIngredient
            // 
            this.btnModifyIngredient.Location = new System.Drawing.Point(180, 174);
            this.btnModifyIngredient.Name = "btnModifyIngredient";
            this.btnModifyIngredient.Size = new System.Drawing.Size(75, 23);
            this.btnModifyIngredient.TabIndex = 4;
            this.btnModifyIngredient.Text = "Modify";
            this.btnModifyIngredient.UseVisualStyleBackColor = true;
            // 
            // txtIngredientID
            // 
            this.txtIngredientID.Location = new System.Drawing.Point(98, 33);
            this.txtIngredientID.Name = "txtIngredientID";
            this.txtIngredientID.Size = new System.Drawing.Size(166, 22);
            this.txtIngredientID.TabIndex = 5;
            // 
            // txtIngredient
            // 
            this.txtIngredient.Location = new System.Drawing.Point(98, 77);
            this.txtIngredient.Name = "txtIngredient";
            this.txtIngredient.Size = new System.Drawing.Size(166, 22);
            this.txtIngredient.TabIndex = 6;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(98, 116);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(166, 22);
            this.txtQuantity.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(450, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "If Ingredient exists then click Modify, \r\nBut if the ingredient does not exist \r\n" +
    "then click Add";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ChefIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grboxModifyIngredients);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ChefIngredients";
            this.Text = "ChefIngredients";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grboxModifyIngredients.ResumeLayout(false);
            this.grboxModifyIngredients.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grboxModifyIngredients;
        private System.Windows.Forms.Button btnModifyIngredient;
        private System.Windows.Forms.Button btnAddIngredient;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblIngredient;
        private System.Windows.Forms.Label lblIngredientID;
        private System.Windows.Forms.TextBox txtIngredientID;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtIngredient;
        private System.Windows.Forms.Label label1;
    }
}