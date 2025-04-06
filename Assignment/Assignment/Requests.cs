using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Requests
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Source\Repos\IOOP_2025_Assignment\Assignment\Assignment\IOOP_Database.mdf;Integrated Security=True";
        //Method to view requests
        public DataTable GetAllRequests()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Request_ID, Email_ID, Type_of_event, Special_Requests, Number_Of_People, Start_Date, Start_Time, End_Time FROM Requests WHERE Approval = 'Pending'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable GetAllReservations()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Reservation_ID, Email_ID, Hall_ID, Reservation_Type, Special_Requests, Status, Booking_Date, Date_when_Booked, Assigned_by FROM Reservations";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}
