namespace Assignment
{
    partial class ChefViewOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChefViewOrders));
            this.btnEditOrder = new System.Windows.Forms.Button();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.ordersTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iOOP_DatabaseDataSet4 = new Assignment.IOOP_DatabaseDataSet4();
            this.order_DetailsTableAdapter = new Assignment.IOOP_DatabaseDataSet4TableAdapters.Order_DetailsTableAdapter();
            this.iOOP_DatabaseDataSet7 = new Assignment.IOOP_DatabaseDataSet7();
            this.ordersTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.orders_TableTableAdapter = new Assignment.IOOP_DatabaseDataSet7TableAdapters.Orders_TableTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iOOP_DatabaseDataSet10 = new Assignment.IOOP_DatabaseDataSet10();
            this.ordersTableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.orders_TableTableAdapter1 = new Assignment.IOOP_DatabaseDataSet10TableAdapters.Orders_TableTableAdapter();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chefDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_DatabaseDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_DatabaseDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_DatabaseDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTableBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditOrder
            // 
            this.btnEditOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btnEditOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditOrder.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditOrder.Location = new System.Drawing.Point(302, 335);
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.Size = new System.Drawing.Size(164, 83);
            this.btnEditOrder.TabIndex = 1;
            this.btnEditOrder.Text = "Edit Order";
            this.btnEditOrder.UseVisualStyleBackColor = false;
            this.btnEditOrder.Click += new System.EventHandler(this.btnEditOrder_Click);
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.BackColor = System.Drawing.Color.Transparent;
            this.lblOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderID.ForeColor = System.Drawing.Color.Black;
            this.lblOrderID.Location = new System.Drawing.Point(203, 296);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(92, 22);
            this.lblOrderID.TabIndex = 2;
            this.lblOrderID.Text = "Order ID:";
            // 
            // txtOrderID
            // 
            this.txtOrderID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrderID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOrderID.Location = new System.Drawing.Point(322, 294);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtOrderID.Size = new System.Drawing.Size(160, 22);
            this.txtOrderID.TabIndex = 3;
            // 
            // ordersTableBindingSource
            // 
            this.ordersTableBindingSource.DataMember = "Orders_Table";
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataMember = "Order_Details";
            this.orderDetailsBindingSource.DataSource = this.iOOP_DatabaseDataSet4;
            // 
            // iOOP_DatabaseDataSet4
            // 
            this.iOOP_DatabaseDataSet4.DataSetName = "IOOP_DatabaseDataSet4";
            this.iOOP_DatabaseDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // order_DetailsTableAdapter
            // 
            this.order_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // iOOP_DatabaseDataSet7
            // 
            this.iOOP_DatabaseDataSet7.DataSetName = "IOOP_DatabaseDataSet7";
            this.iOOP_DatabaseDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableBindingSource1
            // 
            this.ordersTableBindingSource1.DataMember = "Orders_Table";
            this.ordersTableBindingSource1.DataSource = this.iOOP_DatabaseDataSet7;
            // 
            // orders_TableTableAdapter
            // 
            this.orders_TableTableAdapter.ClearBeforeFill = true;
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
            this.dataGridView1.Location = new System.Drawing.Point(115, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(568, 237);
            this.dataGridView1.TabIndex = 4;
            // 
            // iOOP_DatabaseDataSet10
            // 
            this.iOOP_DatabaseDataSet10.DataSetName = "IOOP_DatabaseDataSet10";
            this.iOOP_DatabaseDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableBindingSource2
            // 
            this.ordersTableBindingSource2.DataMember = "Orders_Table";
            this.ordersTableBindingSource2.DataSource = this.iOOP_DatabaseDataSet10;
            // 
            // orders_TableTableAdapter1
            // 
            this.orders_TableTableAdapter1.ClearBeforeFill = true;
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
            // ChefViewOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.btnEditOrder);
            this.Name = "ChefViewOrders";
            this.Text = "ChefViewOrders";
            this.Load += new System.EventHandler(this.ChefViewOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_DatabaseDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_DatabaseDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_DatabaseDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTableBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditOrder;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.BindingSource ordersTableBindingSource;
        private IOOP_DatabaseDataSet4 iOOP_DatabaseDataSet4;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
        private IOOP_DatabaseDataSet4TableAdapters.Order_DetailsTableAdapter order_DetailsTableAdapter;
        private IOOP_DatabaseDataSet7 iOOP_DatabaseDataSet7;
        private System.Windows.Forms.BindingSource ordersTableBindingSource1;
        private IOOP_DatabaseDataSet7TableAdapters.Orders_TableTableAdapter orders_TableTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private IOOP_DatabaseDataSet10 iOOP_DatabaseDataSet10;
        private System.Windows.Forms.BindingSource ordersTableBindingSource2;
        private IOOP_DatabaseDataSet10TableAdapters.Orders_TableTableAdapter orders_TableTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn progressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chefDataGridViewTextBoxColumn;
    }
}