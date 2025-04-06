using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    internal class AddReservation
    {
        //Properties
        private string RequestID { get; set; }
        private string EmailID { get; set; }
        private int HallID { get; set; }
        private string BookingDate { get; set; }
        private string DateWhenBooked { get; set; }
        private string Assignedby {  get; set; }

        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hp\\Source\\Repos\\IOOP_2025_Assignment\\Assignment\\Assignment\\IOOP_Database.mdf;Integrated Security=True";

         public bool InsertData(string RequestID, string EmailID, int HallID, string BookingDate, string DateWhenBooked, string Assignedby)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Reservations (Reservation_ID, Email_ID, Hall_ID, Booking_Date, Date_when_Booked, Assigned_by) VALUES (@Reservation_ID, @Email_ID, @Hall_ID, @Booking_Date, @Date_when_Booked, @Assigned_by)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Reservation_ID", RequestID);
                    cmd.Parameters.AddWithValue("@Email_ID", EmailID);
                    cmd.Parameters.AddWithValue("@Hall_ID", HallID);
                    cmd.Parameters.AddWithValue("@Booking_Date", BookingDate);
                    cmd.Parameters.AddWithValue("@Date_when_Booked", DateWhenBooked);
                    cmd.Parameters.AddWithValue("@Assigned_by", Assignedby);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageBox.Show("Reservation ID already exists or Email ID is not in correct format");
                    }
                    return true; // Returns true if data is inserted
                }

            }


        }
    }

}