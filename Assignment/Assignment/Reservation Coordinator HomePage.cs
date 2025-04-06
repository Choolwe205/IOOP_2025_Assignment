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
           View_Requests_Coordinator obj = new View_Requests_Coordinator();
            obj.ShowDialog();
            this.Close();
        }

        private void btnCustomerReq_Click(object sender, EventArgs e)
        {

        }

        private void Main_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageReservations obj = new ManageReservations();
            obj.ShowDialog();
            this.Close();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin log = new FormLogin();
            log.ShowDialog();
            this.Close();
        }
    }
}
