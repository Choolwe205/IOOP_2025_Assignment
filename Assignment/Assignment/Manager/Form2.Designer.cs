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
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlAddItem = new System.Windows.Forms.Panel();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.pictureBoxAdd = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSaveAdd = new System.Windows.Forms.Button();
            this.txtPrice1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddItem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlEditItem = new System.Windows.Forms.Panel();
            this.btnEditImage = new System.Windows.Forms.Button();
            this.txtSaveEdit = new System.Windows.Forms.Button();
            this.pictureBoxEdit = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEditPrice = new System.Windows.Forms.TextBox();
            this.txtEditID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEditDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlDeleteItem = new System.Windows.Forms.Panel();
            this.btnDeleteItem1 = new System.Windows.Forms.Button();
            this.txtDeleteItem = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.menuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.menuBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.menuBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.iOOP_DatabaseDataSet = new Assignment.IOOP_DatabaseDataSet();
            this.menuBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.menuTableAdapter = new Assignment.IOOP_DatabaseDataSetTableAdapters.MenuTableAdapter();
            this.iOOP_DatabaseDataSet3 = new Assignment.IOOP_DatabaseDataSet3();
            this.menuBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.Food_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Picture = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            this.pnlAddItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).BeginInit();
            this.pnlEditItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdit)).BeginInit();
            this.pnlDeleteItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_DatabaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource7)).BeginInit();
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
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
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
            // 
            // menuBindingSource
            // 
            this.menuBindingSource.DataMember = "Menu";
            // 
            // pnlAddItem
            // 
            this.pnlAddItem.BackColor = System.Drawing.Color.DarkOrange;
            this.pnlAddItem.Controls.Add(this.btnSelectImage);
            this.pnlAddItem.Controls.Add(this.pictureBoxAdd);
            this.pnlAddItem.Controls.Add(this.label9);
            this.pnlAddItem.Controls.Add(this.btnSaveAdd);
            this.pnlAddItem.Controls.Add(this.txtPrice1);
            this.pnlAddItem.Controls.Add(this.label4);
            this.pnlAddItem.Controls.Add(this.txtDescription1);
            this.pnlAddItem.Controls.Add(this.label3);
            this.pnlAddItem.Controls.Add(this.txtAddItem);
            this.pnlAddItem.Controls.Add(this.label2);
            this.pnlAddItem.Location = new System.Drawing.Point(38, 141);
            this.pnlAddItem.Name = "pnlAddItem";
            this.pnlAddItem.Size = new System.Drawing.Size(283, 409);
            this.pnlAddItem.TabIndex = 6;
            this.pnlAddItem.Visible = false;
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Location = new System.Drawing.Point(110, 208);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(121, 23);
            this.btnSelectImage.TabIndex = 9;
            this.btnSelectImage.Text = "Select Image";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // pictureBoxAdd
            // 
            this.pictureBoxAdd.BackColor = System.Drawing.Color.White;
            this.pictureBoxAdd.Location = new System.Drawing.Point(110, 151);
            this.pictureBoxAdd.Name = "pictureBoxAdd";
            this.pictureBoxAdd.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAdd.TabIndex = 8;
            this.pictureBoxAdd.TabStop = false;
            this.pictureBoxAdd.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(4, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Upload Image";
            // 
            // btnSaveAdd
            // 
            this.btnSaveAdd.Location = new System.Drawing.Point(87, 322);
            this.btnSaveAdd.Name = "btnSaveAdd";
            this.btnSaveAdd.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAdd.TabIndex = 6;
            this.btnSaveAdd.Text = "Save";
            this.btnSaveAdd.UseVisualStyleBackColor = true;
            this.btnSaveAdd.Click += new System.EventHandler(this.btnSaveAdd_Click);
            // 
            // txtPrice1
            // 
            this.txtPrice1.Location = new System.Drawing.Point(131, 281);
            this.txtPrice1.Name = "txtPrice1";
            this.txtPrice1.Size = new System.Drawing.Size(100, 22);
            this.txtPrice1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(42, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 19);
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
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(15, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            // 
            // txtAddItem
            // 
            this.txtAddItem.Location = new System.Drawing.Point(110, 55);
            this.txtAddItem.Name = "txtAddItem";
            this.txtAddItem.ReadOnly = true;
            this.txtAddItem.Size = new System.Drawing.Size(100, 22);
            this.txtAddItem.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(42, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Item ID";
            // 
            // pnlEditItem
            // 
            this.pnlEditItem.BackColor = System.Drawing.Color.DarkOrange;
            this.pnlEditItem.Controls.Add(this.btnEditImage);
            this.pnlEditItem.Controls.Add(this.txtSaveEdit);
            this.pnlEditItem.Controls.Add(this.pictureBoxEdit);
            this.pnlEditItem.Controls.Add(this.label10);
            this.pnlEditItem.Controls.Add(this.txtEditPrice);
            this.pnlEditItem.Controls.Add(this.txtEditID);
            this.pnlEditItem.Controls.Add(this.label5);
            this.pnlEditItem.Controls.Add(this.label7);
            this.pnlEditItem.Controls.Add(this.txtEditDescription);
            this.pnlEditItem.Controls.Add(this.label6);
            this.pnlEditItem.Location = new System.Drawing.Point(374, 141);
            this.pnlEditItem.Name = "pnlEditItem";
            this.pnlEditItem.Size = new System.Drawing.Size(283, 409);
            this.pnlEditItem.TabIndex = 7;
            this.pnlEditItem.Visible = false;
            // 
            // btnEditImage
            // 
            this.btnEditImage.Location = new System.Drawing.Point(110, 220);
            this.btnEditImage.Name = "btnEditImage";
            this.btnEditImage.Size = new System.Drawing.Size(121, 23);
            this.btnEditImage.TabIndex = 12;
            this.btnEditImage.Text = "Edit Image";
            this.btnEditImage.UseVisualStyleBackColor = true;
            this.btnEditImage.Click += new System.EventHandler(this.btnEditImage_Click);
            // 
            // txtSaveEdit
            // 
            this.txtSaveEdit.Location = new System.Drawing.Point(110, 333);
            this.txtSaveEdit.Name = "txtSaveEdit";
            this.txtSaveEdit.Size = new System.Drawing.Size(75, 23);
            this.txtSaveEdit.TabIndex = 7;
            this.txtSaveEdit.Text = "Save";
            this.txtSaveEdit.UseVisualStyleBackColor = true;
            this.txtSaveEdit.Click += new System.EventHandler(this.txtSaveEdit_Click);
            // 
            // pictureBoxEdit
            // 
            this.pictureBoxEdit.BackColor = System.Drawing.Color.White;
            this.pictureBoxEdit.Location = new System.Drawing.Point(110, 163);
            this.pictureBoxEdit.Name = "pictureBoxEdit";
            this.pictureBoxEdit.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEdit.TabIndex = 11;
            this.pictureBoxEdit.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(4, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Edit Image";
            // 
            // txtEditPrice
            // 
            this.txtEditPrice.Location = new System.Drawing.Point(110, 281);
            this.txtEditPrice.Name = "txtEditPrice";
            this.txtEditPrice.Size = new System.Drawing.Size(100, 22);
            this.txtEditPrice.TabIndex = 12;
            // 
            // txtEditID
            // 
            this.txtEditID.Location = new System.Drawing.Point(110, 55);
            this.txtEditID.Name = "txtEditID";
            this.txtEditID.Size = new System.Drawing.Size(100, 22);
            this.txtEditID.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(42, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(42, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Item ID";
            // 
            // txtEditDescription
            // 
            this.txtEditDescription.Location = new System.Drawing.Point(110, 111);
            this.txtEditDescription.Name = "txtEditDescription";
            this.txtEditDescription.Size = new System.Drawing.Size(142, 22);
            this.txtEditDescription.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(15, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Description";
            // 
            // pnlDeleteItem
            // 
            this.pnlDeleteItem.BackColor = System.Drawing.Color.DarkOrange;
            this.pnlDeleteItem.Controls.Add(this.btnDeleteItem1);
            this.pnlDeleteItem.Controls.Add(this.txtDeleteItem);
            this.pnlDeleteItem.Controls.Add(this.label8);
            this.pnlDeleteItem.Location = new System.Drawing.Point(721, 141);
            this.pnlDeleteItem.Name = "pnlDeleteItem";
            this.pnlDeleteItem.Size = new System.Drawing.Size(283, 409);
            this.pnlDeleteItem.TabIndex = 8;
            this.pnlDeleteItem.Visible = false;
            // 
            // btnDeleteItem1
            // 
            this.btnDeleteItem1.Location = new System.Drawing.Point(97, 271);
            this.btnDeleteItem1.Name = "btnDeleteItem1";
            this.btnDeleteItem1.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteItem1.TabIndex = 13;
            this.btnDeleteItem1.Text = "Delete";
            this.btnDeleteItem1.UseVisualStyleBackColor = true;
            this.btnDeleteItem1.Click += new System.EventHandler(this.btnDeleteItem1_Click);
            // 
            // txtDeleteItem
            // 
            this.txtDeleteItem.Location = new System.Drawing.Point(117, 64);
            this.txtDeleteItem.Name = "txtDeleteItem";
            this.txtDeleteItem.Size = new System.Drawing.Size(100, 22);
            this.txtDeleteItem.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(49, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Item ID";
            // 
            // menuBindingSource1
            // 
            this.menuBindingSource1.DataMember = "Menu";
            // 
            // menuBindingSource3
            // 
            this.menuBindingSource3.DataMember = "Menu";
            // 
            // dgvMenu
            // 
            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.AllowUserToDeleteRows = false;
            this.dgvMenu.AutoGenerateColumns = false;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Food_ID,
            this.Picture,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvMenu.DataSource = this.menuBindingSource7;
            this.dgvMenu.Location = new System.Drawing.Point(12, 233);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.ReadOnly = true;
            this.dgvMenu.RowHeadersWidth = 51;
            this.dgvMenu.RowTemplate.Height = 24;
            this.dgvMenu.Size = new System.Drawing.Size(547, 236);
            this.dgvMenu.TabIndex = 9;
            // 
            // menuBindingSource6
            // 
            this.menuBindingSource6.DataMember = "Menu";
            // 
            // iOOP_DatabaseDataSet2
            // 
            // 
            // menuBindingSource5
            // 
            this.menuBindingSource5.DataMember = "Menu";
            this.menuBindingSource5.DataSource = this.iOOP_DatabaseDataSet;
            // 
            // iOOP_DatabaseDataSet
            // 
            this.iOOP_DatabaseDataSet.DataSetName = "IOOP_DatabaseDataSet";
            this.iOOP_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuBindingSource4
            // 
            this.menuBindingSource4.DataMember = "Menu";
            // 
            // menuTableAdapter
            // 
            this.menuTableAdapter.ClearBeforeFill = true;
            // 
            // menuTableAdapter1
            // 
            //this.menuTableAdapter1.ClearBeforeFill = true;
            // 
            // iOOP_DatabaseDataSet3
            // 
            this.iOOP_DatabaseDataSet3.DataSetName = "IOOP_DatabaseDataSet3";
            this.iOOP_DatabaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuBindingSource7
            // 
            this.menuBindingSource7.DataMember = "Menu";
            this.menuBindingSource7.DataSource = this.iOOP_DatabaseDataSet3;
            // 
            // menuTableAdapter2
            // 
            //this.menuTableAdapter2.ClearBeforeFill = true;
            // 
            // Food_ID
            // 
            this.Food_ID.DataPropertyName = "Food_ID";
            this.Food_ID.HeaderText = "Food_ID";
            this.Food_ID.MinimumWidth = 6;
            this.Food_ID.Name = "Food_ID";
            this.Food_ID.ReadOnly = true;
            this.Food_ID.Width = 125;
            // 
            // Picture
            // 
            this.Picture.DataPropertyName = "Picture";
            this.Picture.HeaderText = "Picture";
            this.Picture.MinimumWidth = 6;
            this.Picture.Name = "Picture";
            this.Picture.ReadOnly = true;
            this.Picture.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn2.HeaderText = "Description";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn3.HeaderText = "Price";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1039, 668);
            this.Controls.Add(this.pnlAddItem);
            this.Controls.Add(this.pnlEditItem);
            this.Controls.Add(this.pnlDeleteItem);
            this.Controls.Add(this.btnUpdateItem);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnAddItems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMenu);
            this.Name = "Form2";
            this.Text = "Manager-Edit Menu";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            this.pnlAddItem.ResumeLayout(false);
            this.pnlAddItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).EndInit();
            this.pnlEditItem.ResumeLayout(false);
            this.pnlEditItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdit)).EndInit();
            this.pnlDeleteItem.ResumeLayout(false);
            this.pnlDeleteItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_DatabaseDataSet3)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.menuBindingSource7)).EndInit();
            //this.ResumeLayout(false);
            //this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddItems;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnUpdateItem;
        private System.Windows.Forms.BindingSource menuBindingSource;
        private System.Windows.Forms.Panel pnlAddItem;
        private System.Windows.Forms.Button btnSaveAdd;
        private System.Windows.Forms.TextBox txtPrice1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescription1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlEditItem;
        private System.Windows.Forms.Panel pnlDeleteItem;
        private System.Windows.Forms.TextBox txtEditPrice;
        private System.Windows.Forms.TextBox txtEditID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEditDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource menuBindingSource1;
        private System.Windows.Forms.BindingSource menuBindingSource2;
        private System.Windows.Forms.BindingSource menuBindingSource3;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.BindingSource menuBindingSource4;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button txtSaveEdit;
        private System.Windows.Forms.Button btnDeleteItem1;
        private System.Windows.Forms.TextBox txtDeleteItem;
        private System.Windows.Forms.Label label8;
        private IOOP_DatabaseDataSet iOOP_DatabaseDataSet;
        private System.Windows.Forms.BindingSource menuBindingSource5;
        private IOOP_DatabaseDataSetTableAdapters.MenuTableAdapter menuTableAdapter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBoxAdd;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.BindingSource menuBindingSource6;
        private System.Windows.Forms.Button btnEditImage;
        private System.Windows.Forms.PictureBox pictureBoxEdit;
        private System.Windows.Forms.Label label10;
        private IOOP_DatabaseDataSet3 iOOP_DatabaseDataSet3;
        private System.Windows.Forms.BindingSource menuBindingSource7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Food_ID;
        private System.Windows.Forms.DataGridViewImageColumn Picture;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}