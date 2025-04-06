using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Assignment
{
    class View_ReservationClass
    {
        // Properties
        public string Reservation_ID { get; set; }
        public string Email_ID { get; set; }
        public string Hall_ID { get; set; }
        public string Special_Requests { get; set; }
        public string Status { get; set; }
        public DateTime Booking_Date { get; set; }
        public DateTime Date_booked { get; set; }
        public string Assigned_by { get; set; }
        public string Active_email { get; set; }

        // Database connection string
        private string database_connection_string = @"Data Source=(LocalDB)\MSSQLLocalDB; 
            AttachDbFilename=C:\Users\HP 15\OneDrive - Asia Pacific University\Documents\GitHub\IOOP_2025_Assignment\Assignment\Assignment\IOOP_Database.mdf; 
            Integrated Security=True;";

        // Constructor
        public View_ReservationClass(string reservation_ID, string email_ID, string hall_ID, string special_request, string status, DateTime booking_date, DateTime date_booked, string assigned_by, string active_email_)
        {
            this.Reservation_ID = reservation_ID;
            this.Email_ID = email_ID;
            this.Hall_ID = hall_ID;
            this.Special_Requests = special_request;
            this.Status = status;
            this.Booking_Date = booking_date;
            this.Date_booked = date_booked;
            this.Assigned_by = assigned_by;
            this.Active_email = active_email_;
        }

        // Verify reservation by ID and Email.
        public bool VerifyReservation(string reservation_ID, string email_ID)
        {
            bool exists = false;
            using (SqlConnection conn = new SqlConnection(database_connection_string))
            {
                string query = "SELECT COUNT(*) FROM Reservations WHERE Reservation_ID = @Reservation_ID AND Email_ID = @Email_ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Reservation_ID", reservation_ID);
                    cmd.Parameters.AddWithValue("@Email_ID", email_ID);
                    try
                    {
                        conn.Open();
                        int count = (int)cmd.ExecuteScalar();
                        exists = count > 0;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Database error: " + ex.Message);
                    }
                }
            }
            return exists;
        }

        // Show reservation details.
        public string Show_Reservation(string Reservation_ID)
        {
            string result = "";
            using (SqlConnection conn = new SqlConnection(database_connection_string))
            {
                conn.Open();
                string query = "SELECT Reservation_ID, Hall_ID, Reservation_Type, Special_Requests, Status, Booking_Date FROM Reservations WHERE Reservation_ID = @Reservation_ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Reservation_ID", Reservation_ID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            result = $"Reservation ID: {reader["Reservation_ID"]}\n" +
                                     $"Hall ID: {reader["Hall_ID"]}\n" +
                                     $"Type: {reader["Reservation_Type"]}\n" +
                                     $"Requests: {reader["Special_Requests"]}\n" +
                                     $"Status: {reader["Status"]}\n" +
                                     $"Booking Date: {reader["Booking_Date"]}";
                        }
                        else
                        {
                            result = "No reservation found.";
                        }
                    }
                }
            }
            return result;
        }

        // Verify request by ID and Email.
        public bool VerifyRequest(string request_id, string email_ID)
        {
            bool exists = false;
            using (SqlConnection conn = new SqlConnection(database_connection_string))
            {
                string query = "SELECT COUNT(*) FROM Requests WHERE Request_ID = @Request_ID AND Email_ID = @Email_ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Request_ID", request_id);
                    cmd.Parameters.AddWithValue("@Email_ID", email_ID);
                    try
                    {
                        conn.Open();
                        int count = (int)cmd.ExecuteScalar();
                        exists = count > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return exists;
        }
    }
}

