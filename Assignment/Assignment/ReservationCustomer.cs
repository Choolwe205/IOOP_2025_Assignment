using System.Windows.Forms;
using System;

namespace Assignment
{
    public partial class ReservationCustomer : Form
    {
        public ReservationCustomer()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            // Optional: any event code
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Optional: any event code
        }

        private void Return_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if required selections have been made.
                if (ComboEvent.SelectedItem == null || cmbSpecial.SelectedItem == null)
                {
                    MessageBox.Show("Please select an event type and special request.", "Input Error");
                    return;
                }

                // Ensures Email is Entered.
                string email = txtEmail.Text.Trim();
                if (string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Please enter your Email.", "Input Error");
                    return;
                }

                // Validates date and time:
                DateTime now = DateTime.Now;

                if (dtpDate.Value.Date < now.Date ||
                   (dtpDate.Value.Date == now.Date && dtpStart.Value.TimeOfDay < now.TimeOfDay))
                {
                    MessageBox.Show("You cannot make a request before the current date and time.", "Date & Time Error");
                    return;
                }

                if (dtpStart.Value >= dtpEnd.Value)
                {
                    MessageBox.Show("The start time must be earlier than the end time.", "Time Error");
                    return;
                }


                //  Request object with the provided data.
                Request customer_request = new Request(
                    ComboEvent.SelectedItem.ToString(),
                    (int)numcapacity.Value,
                    cmbSpecial.SelectedItem.ToString(),
                    dtpDate.Value,
                    txtAdditonalRequest.Text,
                    dtpStart.Value,
                    dtpEnd.Value,
                    email
                );
                customer_request.add_customers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Optional: any additional event code
        }
    }
}
