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
    public partial class CustomerEditDetails : Form
    {
        public CustomerEditDetails()
        {
            InitializeComponent();
        }

        private void btnReservation1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Details Edited");
        }

        private void btnViewdetails_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Still Under Progress");
        }
    }
}
