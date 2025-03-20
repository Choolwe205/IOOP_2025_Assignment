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
    public partial class CustomerReservation : Form
    {
        public CustomerReservation()
        {
            InitializeComponent();
        }

        private void btnViewPrice_Click(object sender, EventArgs e)
        {
            
        }

        private void btnConfrim_Click(object sender, EventArgs e)
        {
            CustomerReservationDetails newForm = new CustomerReservationDetails();
            newForm.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
