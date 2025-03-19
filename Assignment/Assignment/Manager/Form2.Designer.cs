namespace Assignment.Manager
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddItems = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnUpdateItem = new System.Windows.Forms.Button();
            this.menuBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.iOOP_DatabaseDataSet5 = new Assignment.IOOP_DatabaseDataSet5();
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iOOP_DatabaseDataSet3 = new Assignment.IOOP_DatabaseDataSet3();
            this.menuTableAdapter = new Assignment.IOOP_DatabaseDataSet3TableAdapters.MenuTableAdapter();
            this.pnlAddItem = new System.Windows.Forms.Panel();
            this.btnSaveAdd = new System.Windows.Forms.Button();
            this.txtPrice1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlEditItem = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlDeleteItem = new System.Windows.Forms.Panel();
            this.iOOP_DatabaseDataSet4 = new Assignment.IOOP_DatabaseDataSet4();
            this.menuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuTableAdapter1 = new Assignment.IOOP_DatabaseDataSet4TableAdapters.MenuTableAdapter();
            this.menuTableAdapter2 = new Assignment.IOOP_DatabaseDataSet5TableAdapters.MenuTableAdapter();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.foodIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_DatabaseDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_DatabaseDataSet3)).BeginInit();
            this.pnlAddItem.SuspendLayout();
            this.pnlEditItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_DatabaseDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(365, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manager-Edit Menu";
            // 
            // btnAddItems
            // 
            this.btnAddItems.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAddItems.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItems.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAddItems.Location = new System.Drawing.Point(818, 360);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(166, 75);
            this.btnAddItems.TabIndex = 2;
            this.btnAddItems.Text = "Add an Item";
            this.btnAddItems.UseVisualStyleBackColor = false;
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDeleteItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnDeleteItem.Location = new System.Drawing.Point(818, 488);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(166, 75);
            this.btnDeleteItem.TabIndex = 3;
            this.btnDeleteItem.Text = "Delete Item";
            this.btnDeleteItem.UseVisualStyleBackColor = false;
            // 
            // btnUpdateItem
            // 
            this.btnUpdateItem.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUpdateItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnUpdateItem.Location = new System.Drawing.Point(818, 233);
            this.btnUpdateItem.Name = "btnUpdateItem";
            this.btnUpdateItem.Size = new System.Drawing.Size(166, 75);
            this.btnUpdateItem.TabIndex = 4;
            this.btnUpdateItem.Text = "Update Item";
            this.btnUpdateItem.UseVisualStyleBackColor = false;
            this.btnUpdateItem.Click += new System.EventHandler(this.btnUpdateItem_Click);
            // 
            // menuBindingSource2
            // 
            this.menuBindingSource2.DataMember = "Menu";
            this.menuBindingSource2.DataSource = this.iOOP_DatabaseDataSet5;
            // 
            // iOOP_DatabaseDataSet5
            // 
            this.iOOP_DatabaseDataSet5.DataSetName = "IOOP_DatabaseDataSet5";
            this.iOOP_DatabaseDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuBindingSource
            // 
            this.menuBindingSource.DataMember = "Menu";
            this.menuBindingSource.DataSource = this.iOOP_DatabaseDataSet3;
            // 
            // iOOP_DatabaseDataSet3
            // 
            this.iOOP_DatabaseDataSet3.DataSetName = "IOOP_DatabaseDataSet3";
            this.iOOP_DatabaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuTableAdapter
            // 
            this.menuTableAdapter.ClearBeforeFill = true;
            // 
            // pnlAddItem
            // 
            this.pnlAddItem.Controls.Add(this.btnSaveAdd);
            this.pnlAddItem.Controls.Add(this.txtPrice1);
            this.pnlAddItem.Controls.Add(this.label4);
            this.pnlAddItem.Controls.Add(this.txtDescription1);
            this.pnlAddItem.Controls.Add(this.label3);
            this.pnlAddItem.Controls.Add(this.textBox1);
            this.pnlAddItem.Controls.Add(this.label2);
            this.pnlAddItem.Location = new System.Drawing.Point(38, 141);
            this.pnlAddItem.Name = "pnlAddItem";
            this.pnlAddItem.Size = new System.Drawing.Size(283, 409);
            this.pnlAddItem.TabIndex = 6;
            this.pnlAddItem.Visible = false;
            // 
            // btnSaveAdd
            // 
            this.btnSaveAdd.Location = new System.Drawing.Point(86, 271);
            this.btnSaveAdd.Name = "btnSaveAdd";
            this.btnSaveAdd.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAdd.TabIndex = 6;
            this.btnSaveAdd.Text = "Save";
            this.btnSaveAdd.UseVisualStyleBackColor = true;
            this.btnSaveAdd.Click += new System.EventHandler(this.btnSaveAdd_Click);
            // 
            // txtPrice1
            // 
            this.txtPrice1.Location = new System.Drawing.Point(110, 175);
            this.txtPrice1.Name = "txtPrice1";
            this.txtPrice1.Size = new System.Drawing.Size(100, 22);
            this.txtPrice1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Price";
            // 
            // txtDescription1
            // 
            this.txtDescription1.Location = new System.Drawing.Point(110, 111);
            this.txtDescription1.Name = "txtDescription1";
            this.txtDescription1.Size = new System.Drawing.Size(142, 22);
            this.txtDescription1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Item ID";
            // 
            // pnlEditItem
            // 
            this.pnlEditItem.Controls.Add(this.textBox2);
            this.pnlEditItem.Controls.Add(this.textBox4);
            this.pnlEditItem.Controls.Add(this.label5);
            this.pnlEditItem.Controls.Add(this.label7);
            this.pnlEditItem.Controls.Add(this.textBox3);
            this.pnlEditItem.Controls.Add(this.label6);
            this.pnlEditItem.Location = new System.Drawing.Point(374, 141);
            this.pnlEditItem.Name = "pnlEditItem";
            this.pnlEditItem.Size = new System.Drawing.Size(283, 409);
            this.pnlEditItem.TabIndex = 7;
            this.pnlEditItem.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 175);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(110, 55);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Item ID";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(110, 111);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(142, 22);
            this.textBox3.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Description";
            // 
            // pnlDeleteItem
            // 
            this.pnlDeleteItem.Location = new System.Drawing.Point(721, 141);
            this.pnlDeleteItem.Name = "pnlDeleteItem";
            this.pnlDeleteItem.Size = new System.Drawing.Size(283, 409);
            this.pnlDeleteItem.TabIndex = 8;
            this.pnlDeleteItem.Visible = false;
            // 
            // iOOP_DatabaseDataSet4
            // 
            this.iOOP_DatabaseDataSet4.DataSetName = "IOOP_DatabaseDataSet4";
            this.iOOP_DatabaseDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuBindingSource1
            // 
            this.menuBindingSource1.DataMember = "Menu";
            this.menuBindingSource1.DataSource = this.iOOP_DatabaseDataSet4;
            // 
            // menuTableAdapter1
            // 
            this.menuTableAdapter1.ClearBeforeFill = true;
            // 
            // menuTableAdapter2
            // 
            this.menuTableAdapter2.ClearBeforeFill = true;
            // 
            // dgvMenu
            // 
            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.AllowUserToDeleteRows = false;
            this.dgvMenu.AutoGenerateColumns = false;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.foodIDDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dgvMenu.DataSource = this.menuBindingSource1;
            this.dgvMenu.Location = new System.Drawing.Point(56, 196);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.ReadOnly = true;
            this.dgvMenu.RowHeadersWidth = 51;
            this.dgvMenu.RowTemplate.Height = 24;
            this.dgvMenu.Size = new System.Drawing.Size(432, 151);
            this.dgvMenu.TabIndex = 9;
            // 
            // foodIDDataGridViewTextBoxColumn
            // 
            this.foodIDDataGridViewTextBoxColumn.DataPropertyName = "Food ID";
            this.foodIDDataGridViewTextBoxColumn.HeaderText = "Food ID";
            this.foodIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.foodIDDataGridViewTextBoxColumn.Name = "foodIDDataGridViewTextBoxColumn";
            this.foodIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.foodIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1039, 668);
            this.Controls.Add(this.pnlDeleteItem);
            this.Controls.Add(this.pnlEditItem);
            this.Controls.Add(this.pnlAddItem);
            this.Controls.Add(this.btnUpdateItem);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnAddItems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMenu);
            this.Name = "Form2";
            this.Text = "Manager-Edit Menu";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_DatabaseDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_DatabaseDataSet3)).EndInit();
            this.pnlAddItem.ResumeLayout(false);
            this.pnlAddItem.PerformLayout();
            this.pnlEditItem.ResumeLayout(false);
            this.pnlEditItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_DatabaseDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddItems;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnUpdateItem;
        private IOOP_DatabaseDataSet3 iOOP_DatabaseDataSet3;
        private System.Windows.Forms.BindingSource menuBindingSource;
        private IOOP_DatabaseDataSet3TableAdapters.MenuTableAdapter menuTableAdapter;
        private System.Windows.Forms.Panel pnlAddItem;
        private System.Windows.Forms.Button btnSaveAdd;
        private System.Windows.Forms.TextBox txtPrice1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescription1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlEditItem;
        private System.Windows.Forms.Panel pnlDeleteItem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private IOOP_DatabaseDataSet4 iOOP_DatabaseDataSet4;
        private System.Windows.Forms.BindingSource menuBindingSource1;
        private IOOP_DatabaseDataSet4TableAdapters.MenuTableAdapter menuTableAdapter1;
        private IOOP_DatabaseDataSet5 iOOP_DatabaseDataSet5;
        private System.Windows.Forms.BindingSource menuBindingSource2;
        private IOOP_DatabaseDataSet5TableAdapters.MenuTableAdapter menuTableAdapter2;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}