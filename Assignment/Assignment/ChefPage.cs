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
    public partial class ChefPage : Form
    {
        public ChefPage()
        {
            InitializeComponent();
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            ChefViewOrders chefViewOrders = new ChefViewOrders();
            chefViewOrders.Show();
        }

        private void btnIngredients_Click(object sender, EventArgs e)
        {
            ChefIngredients chefIngredients = new ChefIngredients();
            chefIngredients.Show();
        }
    }
}
