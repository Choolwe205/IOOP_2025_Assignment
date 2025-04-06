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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChefIngredients));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ingredientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iOOP_DatabaseDataSet6 = new Assignment.IOOP_DatabaseDataSet6();
            this.grpModify = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.Quantity = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtIngredientName = new System.Windows.Forms.TextBox();
            this.txtIngredientID = new System.Windows.Forms.TextBox();
            this.ingredientsTableAdapter = new Assignment.IOOP_DatabaseDataSet6TableAdapters.IngredientsTableAdapter();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblIngredient = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_DatabaseDataSet6)).BeginInit();
            this.grpModify.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ingredientIDDataGridViewTextBoxColumn,
            this.ingredientNameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ingredientsBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.dataGridView1.Location = new System.Drawing.Point(12, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(492, 466);
            this.dataGridView1.TabIndex = 0;
            // 
            // ingredientIDDataGridViewTextBoxColumn
            // 
            this.ingredientIDDataGridViewTextBoxColumn.DataPropertyName = "Ingredient_ID";
            this.ingredientIDDataGridViewTextBoxColumn.HeaderText = "Ingredient_ID";
            this.ingredientIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ingredientIDDataGridViewTextBoxColumn.Name = "ingredientIDDataGridViewTextBoxColumn";
            this.ingredientIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ingredientIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // ingredientNameDataGridViewTextBoxColumn
            // 
            this.ingredientNameDataGridViewTextBoxColumn.DataPropertyName = "Ingredient_Name";
            this.ingredientNameDataGridViewTextBoxColumn.HeaderText = "Ingredient_Name";
            this.ingredientNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ingredientNameDataGridViewTextBoxColumn.Name = "ingredientNameDataGridViewTextBoxColumn";
            this.ingredientNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.ingredientNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // ingredientsBindingSource
            // 
            this.ingredientsBindingSource.DataMember = "Ingredients";
            this.ingredientsBindingSource.DataSource = this.iOOP_DatabaseDataSet6;
            // 
            // iOOP_DatabaseDataSet6
            // 
            this.iOOP_DatabaseDataSet6.DataSetName = "IOOP_DatabaseDataSet6";
            this.iOOP_DatabaseDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grpModify
            // 
            this.grpModify.BackColor = System.Drawing.Color.Transparent;
            this.grpModify.Controls.Add(this.label4);
            this.grpModify.Controls.Add(this.btnDelete);
            this.grpModify.Controls.Add(this.btnEdit);
            this.grpModify.Controls.Add(this.btnAdd);
            this.grpModify.Controls.Add(this.Quantity);
            this.grpModify.Controls.Add(this.label2);
            this.grpModify.Controls.Add(this.label1);
            this.grpModify.Controls.Add(this.txtQuantity);
            this.grpModify.Controls.Add(this.txtIngredientName);
            this.grpModify.Controls.Add(this.txtIngredientID);
            this.grpModify.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpModify.Location = new System.Drawing.Point(510, 48);
            this.grpModify.Name = "grpModify";
            this.grpModify.Size = new System.Drawing.Size(406, 466);
            this.grpModify.TabIndex = 1;
            this.grpModify.TabStop = false;
            this.grpModify.Text = "Modify Ingredients";
            this.grpModify.Enter += new System.EventHandler(this.grpModify_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "IngredientID";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(273, 227);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 33);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Location = new System.Drawing.Point(145, 227);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(103, 33);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(15, 227);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 33);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.Location = new System.Drawing.Point(92, 152);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(65, 19);
            this.Quantity.TabIndex = 5;
            this.Quantity.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingredient";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 3;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Location = new System.Drawing.Point(175, 152);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(186, 29);
            this.txtQuantity.TabIndex = 2;
            // 
            // txtIngredientName
            // 
            this.txtIngredientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIngredientName.Location = new System.Drawing.Point(175, 97);
            this.txtIngredientName.Name = "txtIngredientName";
            this.txtIngredientName.Size = new System.Drawing.Size(186, 29);
            this.txtIngredientName.TabIndex = 1;
            // 
            // txtIngredientID
            // 
            this.txtIngredientID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIngredientID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIngredientID.Location = new System.Drawing.Point(175, 45);
            this.txtIngredientID.Name = "txtIngredientID";
            this.txtIngredientID.Size = new System.Drawing.Size(186, 29);
            this.txtIngredientID.TabIndex = 0;
            // 
            // ingredientsTableAdapter
            // 
            this.ingredientsTableAdapter.ClearBeforeFill = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(401, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 30);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(171, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(224, 22);
            this.txtSearch.TabIndex = 10;
            // 
            // lblIngredient
            // 
            this.lblIngredient.AutoSize = true;
            this.lblIngredient.BackColor = System.Drawing.Color.Transparent;
            this.lblIngredient.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredient.Location = new System.Drawing.Point(53, 15);
            this.lblIngredient.Name = "lblIngredient";
            this.lblIngredient.Size = new System.Drawing.Size(99, 24);
            this.lblIngredient.TabIndex = 10;
            this.lblIngredient.Text = "Ingredient";
            // 
            // ChefIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(979, 526);
            this.Controls.Add(this.lblIngredient);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.grpModify);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ChefIngredients";
            this.Text = "Chef Ingredients";
            this.Load += new System.EventHandler(this.ChefIngredients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_DatabaseDataSet6)).EndInit();
            this.grpModify.ResumeLayout(false);
            this.grpModify.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtIngredientName;
        private System.Windows.Forms.TextBox txtIngredientID;
        private System.Windows.Forms.Label label4;
        private IOOP_DatabaseDataSet6 iOOP_DatabaseDataSet6;
        private System.Windows.Forms.BindingSource ingredientsBindingSource;
        private IOOP_DatabaseDataSet6TableAdapters.IngredientsTableAdapter ingredientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblIngredient;
    }
}