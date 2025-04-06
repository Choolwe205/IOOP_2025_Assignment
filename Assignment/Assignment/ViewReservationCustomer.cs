using System;
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
            // Empty event handler (if not used)
        }

        private void Return_Click(object sender, EventArgs e)
        {
            string Email = txtEmail.Text.Trim();
            string reservation_id = txtReservationId.Text.Trim();

            if (string.IsNullOrEmpty(reservation_id) || string.IsNullOrEmpty(Email))
            {
                MessageBox.Show("Please enter both Reservation ID and Email.", "Input Error", MessageBoxButtons.OK);
                return;
            }

            // Verify the reservation using the provided Email.
            View_ReservationClass reservation = new View_ReservationClass("", Email, "", "", "", DateTime.Now, DateTime.Now, "", "");
            bool isValid = reservation.VerifyReservation(reservation_id, Email);

            if (isValid)
            {
                MessageBox.Show("Reservation Details Verified");
                View_ReservationClass rm = new View_ReservationClass(reservation_id, Email, "", "", "", DateTime.Now, DateTime.Now, "", "");
                string details = rm.Show_Reservation(reservation_id);
                label1.Text = details;
            }
            else
            {
                MessageBox.Show("Invalid reservation.", "Wrong Information Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Details viewed");
            this.Hide();
        }

        private void ViewReservationCustomer_Load(object sender, EventArgs e)
        {
            //empty event handler 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Email = txtEmail_ID.Text.Trim();
            int request_id;
            if (string.IsNullOrEmpty(Email) || !int.TryParse(txtRequestID.Text.Trim(), out request_id) || request_id == 0)
            {
                MessageBox.Show("Please provide a valid Request ID and Email.", "Input Error", MessageBoxButtons.OK);
                return;
            }

            // Verify that the request belongs to the customer.
            View_ReservationClass requestVerifier = new View_ReservationClass("", Email, "", "", "", DateTime.Now, DateTime.Now, "", "");
            bool isValid = requestVerifier.VerifyRequest(request_id.ToString(), Email);
            if (isValid)
            {
                MessageBox.Show("Request Details Verified");
                // Create a Request instance with the Email to view the request.
                Request view = new Request("", 0, "", DateTime.Now, "", DateTime.Now, DateTime.Now, Email);
                string details = view.Show_Request(txtRequestID.Text);
                label1.Text = details;
            }
            else
            {
                MessageBox.Show("Invalid request.", "Wrong Information Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtRequestID_TextChanged(object sender, EventArgs e)
        {
            //empty event handler
        }
    }
}