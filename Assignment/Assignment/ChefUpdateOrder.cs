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

namespace Assignment
{
    public partial class ChefUpdateOrder : Form
    {
        private string orderId;
        private ChefOrders cheforders;

        public ChefUpdateOrder(string orderId, string Email_ID)
        {
            InitializeComponent();
            this.orderId = orderId;
            cheforders = new ChefOrders();
            LoadOrderDetails();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string newProgress = txtProgress.Text.Trim();
            string chefName = txtChef.Text.Trim(); 

            if (string.IsNullOrEmpty(newProgress))
            {
                MessageBox.Show("Please enter a progress update.");
                return;
            }

            if (string.IsNullOrEmpty(chefName))
            {
                MessageBox.Show("Please enter the chef's name.");
                return;
            }

            cheforders.UpdateOrderProgress(orderId, newProgress, chefName);
            MessageBox.Show("Order progress and chef updated successfully.");
            this.Close();
        }

        private void LoadOrderDetails()
        {
            dataGridView1.DataSource = cheforders.GetOrderDetails(orderId);
        }

        private void ChefUpdateOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iOOP_DatabaseDataSet9.Orders_Table' table. You can move, or remove it, as needed.
            this.orders_TableTableAdapter2.Fill(this.iOOP_DatabaseDataSet9.Orders_Table);
            // TODO: This line of code loads data into the 'iOOP_DatabaseDataSet8.Orders_Table' table. You can move, or remove it, as needed.
            this.orders_TableTableAdapter1.Fill(this.iOOP_DatabaseDataSet8.Orders_Table);
            // TODO: This line of code loads data into the 'iOOP_DatabaseDataSet2.Orders_Table' table. You can move, or remove it, as needed.
            this.orders_TableTableAdapter.Fill(this.iOOP_DatabaseDataSet2.Orders_Table);
            // TODO: This line of code loads data into the 'iOOP_DatabaseDataSet.Menu' table. You can move, or remove it, as needed.
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtProgress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
