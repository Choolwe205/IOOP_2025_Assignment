using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment.Manager;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment
{
    public partial class ManageReservations : Form
    {
        public ManageReservations()
        {
            InitializeComponent();

            Requests gg = new Requests();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gg.GetAllReservations();
            dataGridView1.Refresh();
            dataGridView1.Update();

            
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            string Reservation_ID = ReservationID_txtbox.Text;
            string DateOfEvent = date_txtbox.Text;
            string Status = status_txtbox.Text;
            string Reservation_Type = ReservationType_txtbox.Text;

            EditDeleteReservation Edit = new EditDeleteReservation(Reservation_ID, DateOfEvent, Status, Reservation_Type);


            bool truth_value = Edit.Updatedata();
            if (truth_value == true)
            {
                MessageBox.Show("Reservation edited successfully!");
            }
            else
            {
                MessageBox.Show("Failed to edit reservation");
            }
        }

        private void confirm_btn2_Click(object sender, EventArgs e)
        {
            
            string DateOfEvent = "";
            string Status = "";
            string Reservation_Type = "";
            string Reservation_ID = txtreserveidDelete.Text;

            EditDeleteReservation Edit2 = new EditDeleteReservation(Reservation_ID, DateOfEvent, Status, Reservation_Type);

            bool truth_value = Edit2.DeleteReservation();
            if (truth_value == true)
            {
                MessageBox.Show("Reservation deleted successfully!");
            }
            else
            {
                MessageBox.Show("Failed delete reservation");
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnbackMR_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Dashboard main_Dashboard = new Main_Dashboard("mwilachibesa@gmail.com");
            main_Dashboard.ShowDialog();
            this.Close();

        }
    }
}
