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
    public partial class ViewReservationCustomer : Form
    {
        public ViewReservationCustomer()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Return_Click(object sender, EventArgs e)
        {
            CustomerReservationDetails details = new CustomerReservationDetails();
            details.ShowDialog();
            this.Hide();
        }
    }
}
