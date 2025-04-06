using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.Manager;

namespace Assignment
{

    internal class EditDeleteReservation
    {
        private string Reservation_ID { get; set; }
        private string DateOfEvent { get; set; }
        private string Status { get; set; }
        private string Reservation_Type { get; set; }
        

        //Method

        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hp\\Source\\Repos\\IOOP_2025_Assignment\\Assignment\\Assignment\\IOOP_Database.mdf;Integrated Security=True";
        public bool Updatedata()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Reservations SET Booking_Date = @Booking_Date, [Status] = @Status, [Reservation_Type] = @Reservation_Type WHERE Reservation_ID = @Reservation_ID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    
                    cmd.Parameters.AddWithValue("@Reservation_ID", Reservation_ID);
                    cmd.Parameters.AddWithValue("@Booking_Date", DateOfEvent);
                    cmd.Parameters.AddWithValue("@Status", Status);
                    cmd.Parameters.AddWithValue("@Reservation_Type", Reservation_Type);
                    int count = cmd.ExecuteNonQuery();
                    return true;
                }
            }
      
        }
        //constructor
        public EditDeleteReservation(string reservation_id, string dateofevent, string status, string reservation_type)
        {
            this.Reservation_ID = reservation_id;
            this.DateOfEvent = dateofevent;
            this.Status = status;
            this.Reservation_Type = reservation_type;

        }
        //Method
        public bool DeleteReservation()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = $"DELETE FROM Reservations WHERE Reservation_ID ='{Reservation_ID}'";
                SqlCommand cmd = new SqlCommand(query, conn);
                

                cmd.ExecuteNonQuery();
                conn.Close();
                return true;



            }
        }
    }
    
    

}