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
            
            CustomerOrderDetails details = new CustomerOrderDetails();
            details.ShowDialog();
            this.Hide();
        }
    }
}
