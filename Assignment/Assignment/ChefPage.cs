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
        string email;

        public ChefPage(string Email_ID)
        {
            InitializeComponent();
            email = Email_ID;   
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            ChefViewOrders chefViewOrders = new ChefViewOrders(email);
            chefViewOrders.Show();
        }

        private void btnIngredients_Click(object sender, EventArgs e)
        {
            ChefIngredients chefIngredients = new ChefIngredients(email);
            chefIngredients.Show();
        }

        private void ChefPage_Load(object sender, EventArgs e)
        {

        }

        private void btnChefViewProfile_Click(object sender, EventArgs e)
        {
            Form2 cheflogin = new Form2(email);
            cheflogin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }
    }
}
