using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class ChefViewOrders : Form
    {
        public ChefViewOrders()
        {
            InitializeComponent();
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            ChefUpdateOrder chefUpdateOrder = new ChefUpdateOrder();
            chefUpdateOrder.Show();
        }
    }
}
