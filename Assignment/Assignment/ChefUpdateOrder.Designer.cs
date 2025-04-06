namespace Assignment
{
    partial class ChefUpdateOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChefUpdateOrder));
            this.btnSave = new System.Windows.Forms.Button();
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iOOP_DatabaseDataSet5 = new Assignment.IOOP_DatabaseDataSet5();
            this.order_DetailsTableAdapter = new Assignment.IOOP_DatabaseDataSet5TableAdapters.Order_DetailsTableAdapter();
            this.txtProgress = new System.Windows.Forms.TextBox();
            this.txtChef = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iOOP_DatabaseDataSet = new Assignment.IOOP_DatabaseDataSet();
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuTableAdapter = new Assignment.IOOP_DatabaseDataSetTableAdapters.MenuTableAdapter();
            this.menuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.iOOP_DatabaseDataSet2 = new Assignment.IOOP_DatabaseDataSet2();
            this.ordersTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orders_TableTableAdapter = new Assignment.IOOP_DatabaseDataSet2TableAdapters.Orders_TableTableAdapter();
            this.iOOP_DatabaseDataSet8 = new Assignment.IOOP_DatabaseDataSet8();
            this.ordersTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.orders_TableTableAdapter1 = new Assignment.IOOP_DatabaseDataSet8TableAdapters.Orders_TableTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iOOP_DatabaseDataSet9 = new Assignment.IOOP_DatabaseDataSet9();
            this.ordersTableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.orders_TableTableAdapter2 = new Assignment.IOOP_DatabaseDataSet9TableAdapters.Orders_TableTableAdapter();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chefDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_DatabaseDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_DatabaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_DatabaseDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_DatabaseDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTableBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(265, 361);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(252, 77);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataMember = "Order_Details";
            this.orderDetailsBindingSource.DataSource = this.iOOP_DatabaseDataSet5;
            // 
            // iOOP_DatabaseDataSet5
            // 
            this.iOOP_DatabaseDataSet5.DataSetName = "IOOP_DatabaseDataSet5";
            this.iOOP_DatabaseDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // order_DetailsTableAdapter
            // 
            this.order_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // txtProgress
            // 
            this.txtProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProgress.Location = new System.Drawing.Point(222, 301);
            this.txtProgress.Name = "txtProgress";
            this.txtProgress.Size = new System.Drawing.Size(180, 22);
            this.txtProgress.TabIndex = 2;
            this.txtProgress.TextChanged += new System.EventHandler(this.txtProgress_TextChanged);
            // 
            // txtChef
            // 
            this.txtChef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChef.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChef.Location = new System.Drawing.Point(507, 301);
            this.txtChef.Name = "txtChef";
            this.txtChef.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtChef.Size = new System.Drawing.Size(175, 22);
            this.txtChef.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(423, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Chef:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Progress:";
            // 
            // iOOP_DatabaseDataSet
            // 
            this.iOOP_DatabaseDataSet.DataSetName = "IOOP_DatabaseDataSet";
            this.iOOP_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuBindingSource
            // 
            this.menuBindingSource.DataMember = "Menu";
            this.menuBindingSource.DataSource = this.iOOP_DatabaseDataSet;
            // 
            // menuTableAdapter
            // 
            this.menuTableAdapter.ClearBeforeFill = true;
            // 
            // menuBindingSource1
            // 
            this.menuBindingSource1.DataMember = "Menu";
            this.menuBindingSource1.DataSource = this.iOOP_DatabaseDataSet;
            // 
            // menuBindingSource2
            // 
            this.menuBindingSource2.DataMember = "Menu";
            this.menuBindingSource2.DataSource = this.iOOP_DatabaseDataSet;
            // 
            // iOOP_DatabaseDataSet2
            // 
            this.iOOP_DatabaseDataSet2.DataSetName = "IOOP_DatabaseDataSet2";
            this.iOOP_DatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableBindingSource
            // 
            this.ordersTableBindingSource.DataMember = "Orders_Table";
            this.ordersTableBindingSource.DataSource = this.iOOP_DatabaseDataSet2;
            // 
            // orders_TableTableAdapter
            // 
            this.orders_TableTableAdapter.ClearBeforeFill = true;
            // 
            // iOOP_DatabaseDataSet8
            // 
            this.iOOP_DatabaseDataSet8.DataSetName = "IOOP_DatabaseDataSet8";
            this.iOOP_DatabaseDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableBindingSource1
            // 
            this.ordersTableBindingSource1.DataMember = "Orders_Table";
            this.ordersTableBindingSource1.DataSource = this.iOOP_DatabaseDataSet8;
            // 
            // orders_TableTableAdapter1
            // 
            this.orders_TableTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.emailIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.progressDataGridViewTextBoxColumn,
            this.chefDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ordersTableBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(148, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(534, 258);
            this.dataGridView1.TabIndex = 10;
            // 
            // iOOP_DatabaseDataSet9
            // 
            this.iOOP_DatabaseDataSet9.DataSetName = "IOOP_DatabaseDataSet9";
            this.iOOP_DatabaseDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableBindingSource2
            // 
            this.ordersTableBindingSource2.DataMember = "Orders_Table";
            this.ordersTableBindingSource2.DataSource = this.iOOP_DatabaseDataSet9;
            // 
            // orders_TableTableAdapter2
            // 
            this.orders_TableTableAdapter2.ClearBeforeFill = true;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "Order_ID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "Order_ID";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailIDDataGridViewTextBoxColumn
            // 
            this.emailIDDataGridViewTextBoxColumn.DataPropertyName = "Email_ID";
            this.emailIDDataGridViewTextBoxColumn.HeaderText = "Email_ID";
            this.emailIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailIDDataGridViewTextBoxColumn.Name = "emailIDDataGridViewTextBoxColumn";
            this.emailIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // progressDataGridViewTextBoxColumn
            // 
            this.progressDataGridViewTextBoxColumn.DataPropertyName = "Progress";
            this.progressDataGridViewTextBoxColumn.HeaderText = "Progress";
            this.progressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.progressDataGridViewTextBoxColumn.Name = "progressDataGridViewTextBoxColumn";
            this.progressDataGridViewTextBoxColumn.ReadOnly = true;
            this.progressDataGridViewTextBoxColumn.Width = 125;
            // 
            // chefDataGridViewTextBoxColumn
            // 
            this.chefDataGridViewTextBoxColumn.DataPropertyName = "Chef";
            this.chefDataGridViewTextBoxColumn.HeaderText = "Chef";
            this.chefDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chefDataGridViewTextBoxColumn.Name = "chefDataGridViewTextBoxColumn";
            this.chefDataGridViewTextBoxColumn.ReadOnly = true;
            this.chefDataGridViewTextBoxColumn.Width = 125;
            // 
            // ChefUpdateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtChef);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProgress);
            this.Controls.Add(this.btnSave);
            this.Name = "ChefUpdateOrder";
            this.Text = "ChefUpdateOrder";
            this.Load += new System.EventHandler(this.ChefUpdateOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_DatabaseDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_DatabaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_DatabaseDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_DatabaseDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTableBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private IOOP_DatabaseDataSet5 iOOP_DatabaseDataSet5;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
        private IOOP_DatabaseDataSet5TableAdapters.Order_DetailsTableAdapter order_DetailsTableAdapter;
        private System.Windows.Forms.TextBox txtProgress;
        private System.Windows.Forms.TextBox txtChef;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private IOOP_DatabaseDataSet iOOP_DatabaseDataSet;
        private System.Windows.Forms.BindingSource menuBindingSource;
        private IOOP_DatabaseDataSetTableAdapters.MenuTableAdapter menuTableAdapter;
        private System.Windows.Forms.BindingSource menuBindingSource1;
        private System.Windows.Forms.BindingSource menuBindingSource2;
        private IOOP_DatabaseDataSet2 iOOP_DatabaseDataSet2;
        private System.Windows.Forms.BindingSource ordersTableBindingSource;
        private IOOP_DatabaseDataSet2TableAdapters.Orders_TableTableAdapter orders_TableTableAdapter;
        private IOOP_DatabaseDataSet8 iOOP_DatabaseDataSet8;
        private System.Windows.Forms.BindingSource ordersTableBindingSource1;
        private IOOP_DatabaseDataSet8TableAdapters.Orders_TableTableAdapter orders_TableTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private IOOP_DatabaseDataSet9 iOOP_DatabaseDataSet9;
        private System.Windows.Forms.BindingSource ordersTableBindingSource2;
        private IOOP_DatabaseDataSet9TableAdapters.Orders_TableTableAdapter orders_TableTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn progressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chefDataGridViewTextBoxColumn;
    }
}