using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Assignment
{
    public partial class ChefViewOrders : Form
    {
        private ChefOrders cheforders;
        String email;
        
        public ChefViewOrders(string Email_ID)
        {
            InitializeComponent();
            cheforders = new ChefOrders();
            LoadOrders();
            email = Email_ID;
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            string orderId = txtOrderID.Text.Trim();

            if (string.IsNullOrEmpty(orderId))
            {
                MessageBox.Show("Please enter an Order ID.");
                return;
            }

            if (cheforders.OrderExists(orderId))
            {
                ChefUpdateOrder editForm = new ChefUpdateOrder(orderId, email);
                editForm.Show();
            }
            else
            {
                MessageBox.Show("Order ID not found.");
            }
        }

        private void LoadOrders()
        {
            dataGridView1.DataSource = cheforders.GetOrders();
        }

        private void ChefViewOrders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iOOP_DatabaseDataSet10.Orders_Table' table. You can move, or remove it, as needed.
            this.orders_TableTableAdapter1.Fill(this.iOOP_DatabaseDataSet10.Orders_Table);
            // TODO: This line of code loads data into the 'iOOP_DatabaseDataSet7.Orders_Table' table. You can move, or remove it, as needed.
            this.orders_TableTableAdapter.Fill(this.iOOP_DatabaseDataSet7.Orders_Table);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Placeholder for any future functionality
        }
    }
}
