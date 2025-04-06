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
    public partial class Main_Dashboard : Form
    {
        public Main_Dashboard(string Email_ID)
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewReservation obj = new ViewReservation();
            obj.ShowDialog();
            this.Close();
        }

        private void btnCustomerReq_Click(object sender, EventArgs e)
        {

        }
    }
}
