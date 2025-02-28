using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classespractice
{
    public partial class Customer_Index : Form
    {
        public Customer_Index()
        {
            InitializeComponent();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            Customer_Reservation secondForm = new Customer_Reservation(); // Create an instance of Form2
            secondForm.Show(); // Open Form2
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Customer_Menu thirdForm = new Customer_Menu();
            thirdForm.Show();
        }
    }
}
