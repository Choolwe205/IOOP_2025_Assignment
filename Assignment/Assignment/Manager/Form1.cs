using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment.Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iOOP_DatabaseDataSet10.Resrvations' table. You can move, or remove it, as needed.
            this.resrvationsTableAdapter.Fill(this.iOOP_DatabaseDataSet10.Resrvations);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnManageMenu_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); // Create an instance of Form3
            form2.Show(); // Show Form3
        }

        private void btnManageHalls_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(); // Create an instance of Form3
            form3.Show(); // Show Form3
        }

        private void btnPastReservations_Click(object sender, EventArgs e)
        {

        }

        private void btnHallReport_Click(object sender, EventArgs e)
        {
            pnlReservationReport.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlReservationReport.Visible=false;
        }
    }
}
