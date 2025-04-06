using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Assignment.Manager;

namespace Assignment
{
    public partial class View_Requests_Coordinator : Form
    {
        Verifying Verifying = new Verifying();
        AddReservation addReservation = new AddReservation();
        public View_Requests_Coordinator()
        {
            InitializeComponent();

            lood_name();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void lood_name()
        {


            Requests gg = new Requests();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gg.GetAllRequests();
            dataGridView1.Refresh();
            dataGridView1.Update();

            HallManager hh = new HallManager();
            dataGridHalls.DataSource = null;
            dataGridHalls.DataSource = hh.GetAllHalls();
            dataGridHalls.Refresh();
            dataGridHalls.Update();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnaddreserve_Click(object sender, EventArgs e)
        {
            string RequestID = txtreservationid.Text;
            string EmailID = txtemailid.Text;
            int HallID = int.Parse(txthallid.Text);
            string BookingDate = txtbookdate.Text;
            string DateWhenBooked = txtdatewhen.Text;
            string Assignedby = txtassighned.Text;

            int reservation_count = Verifying.verifying_reservation_ID(RequestID);


            if (checkHallnotAV.Checked)
            {
                string connection_string = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hp\\Source\\Repos\\IOOP_2025_Assignment\\Assignment\\Assignment\\IOOP_Database.mdf;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connection_string);
                conn.Open();
                string query = $"UPDATE Requests SET Approval = 'Rejected' WHERE Email_ID = '{EmailID}'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else if (EmailID == null && checkHallnotAV.Checked)
            {
                MessageBox.Show("Enter Email ID to update");
            }
            else
            {
                bool truth_value = addReservation.InsertData(RequestID, EmailID, HallID, BookingDate, DateWhenBooked, Assignedby);
                if (truth_value == true && reservation_count == 0)
                {
                    MessageBox.Show("Reservation added successfully!");
                    string connection_string = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hp\\Source\\Repos\\IOOP_2025_Assignment\\Assignment\\Assignment\\IOOP_Database.mdf;Integrated Security=True";
                    SqlConnection conn = new SqlConnection(connection_string);
                    conn.Open();
                    string query = $"UPDATE Requests SET Approval = 'Confirmed' WHERE Email_ID = '{EmailID}'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                else if (reservation_count > 0)
                {
                    MessageBox.Show("Reservation ID Already Exists");
                }
                else
                {
                    MessageBox.Show("Failed to add reservation");
                }
            }

            panel1.Visible = false;



        }

        private void reservation_btn_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void btnbackVR_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Dashboard main_Dashboard = new Main_Dashboard("mwilachibesa@gmail.com");
            main_Dashboard.ShowDialog();
            this.Close();

        }
    }
}
    

