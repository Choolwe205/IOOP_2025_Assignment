using System;
using System.Collections;
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
    public partial class ViewReservation : Form
    {
        public ViewReservation()
        {
            InitializeComponent();
        }

        private void ViewReservation_Load(object sender, EventArgs e)
        {

            ArrayList store = Reservation.showData();

            for (int i = 0; i < store.Count; i++)
            {
                lstboxHold.Items.Add(store[i]);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable sqldbl = Reservation.DataValue(txtUsername.Text);

            if (sqldbl.Rows.Count > 0)
            {
                dataGrid.DataSource = sqldbl;
            }
            else
                MessageBox.Show("There is no such username!");

        }
    }
}

        
    

