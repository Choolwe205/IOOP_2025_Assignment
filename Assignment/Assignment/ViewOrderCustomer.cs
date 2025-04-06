using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment.Resources;

namespace Assignment
{
    public partial class ViewOrderCustomer : Form
    {
        public ViewOrderCustomer()
        {
            InitializeComponent();
        }

        private void Return_Click(object sender, EventArgs e)
        {

            string email = txtEmail.Text.Trim();
            string orderId = txtOrder_Id.Text.Trim();

            // Validate input fields
            if (string.IsNullOrEmpty(orderId) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter both Order ID and Email.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Created  an instance of the class which is an object 
            ViewOrderClass order = new ViewOrderClass(orderId);

            // Checks if the order exists in Table
            if (order.VerifyOrderCustomer(orderId, email))
            {
                MessageBox.Show("Order Details Verified", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Display order details here
            }
            else
            {
                MessageBox.Show("Invalid order.", "Wrong Information Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string order_id =txtOrder_Id.Text.Trim();

            ViewOrderClass view= new ViewOrderClass(order_id);
            string details=view.ShowCustomerOrder(order_id);


            details=label3.Text.Trim();
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ALL DONE!");
            this.Hide();
        }
    }
}
