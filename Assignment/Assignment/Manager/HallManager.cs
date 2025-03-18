using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Assignment.Manager
{
    public class HallManager
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\CYBORG\source\repos\IOOP_2025_Assignment\Assignment\Assignment\IOOP_Database.mdf;Integrated Security=True";

        public DataTable GetAllHalls()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Halls";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public void AddHall(int capacity)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Halls (Capacity, Availability) VALUES (@Capacity, 'Available')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Capacity", capacity);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void EditHall(int hallID, int capacity, string availability)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Halls SET Capacity = @Capacity, Availability = @Availability WHERE HallID = @HallID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@HallID", hallID);
                cmd.Parameters.AddWithValue("@Capacity", capacity);
                cmd.Parameters.AddWithValue("@Availability", availability);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void DeleteHall(int hallID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Halls WHERE HallID = @HallID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@HallID", hallID);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
