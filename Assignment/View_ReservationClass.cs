
using System;
namespace Assignment
{
    class View_ReservationClass
    {
        string Reservation_ID { get; set; }
        string Email_ID { get; set; }
        string Hall_ID { get; set; }
        string Special_Requests { get; set; }
        string Status { get; set; }
        DateTime Booking_Date { get; set; }
        DateTime Date_booked { get; set; }
        string Assigned_by { get; set; }

        private string database_connection_string = @"Data Source=(LocalDB)\MSSQLLocalDB; 
    AttachDbFilename=C:\Users\HP 15\OneDrive - Asia Pacific University\Documents\GitHub\IOOP_2025_Assignment\Assignment\Assignment\IOOP_Database.mdf; 
    Integrated Security=True;"


    public View_ReservationClass(string reservation_ID, string email_ID, string hall_ID, string special_request, string status, DateTime booking_date, DateTime date_booked, string assigned_by)
        {
            this.Reservation_ID = reservation_ID;
            this.Email_ID = email_ID;
            this.Hall_ID = hall_ID;
            this.Special_Requests = special_request;
            this.Status = status;
            this.Booking_Date = booking_date;
            this.Date_booked = date_booked;
            this.Assigned_by = assigned_by;


        }
        //method for checking reservation_id and email from reservation table to verify user, no output

        public bool VerifyReservation(string reservation_ID, string email_ID)
        {
            bool exists = false;

            using (SqlConnection conn = new SqlConnection(database_connection_string))
            {
                string query = "SELECT COUNT(*) FROM Reservations WHERE Reservation_ID = @Reservation_ID AND Email_ID = @Email_ID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Reservation_ID", reservation_ID);
                cmd.Parameters.AddWithValue("@Email_ID", email_ID);

                try
                {
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar(); // Get the count of matching rows
                    exists = count > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Database error: " + ex.Message); //logs the error
                }
            }

            return exists;
        }
    }

}




