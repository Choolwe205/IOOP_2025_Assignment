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
    public partial class CustomerViewReservation : Form
    {
        public CustomerViewReservation()
        {
            InitializeComponent();
        }

        private void btnReservation1_Click(object sender, EventArgs e)
        {
            CustomerReservationDetails newForm = new CustomerReservationDetails();
            newForm.ShowDialog();
        }
    }
}
