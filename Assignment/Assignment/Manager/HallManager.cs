using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Assignment.Manager
{
    public class HallManager
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ranja\Source\Repos\IOOP_2025_Assignment\Assignment\Assignment\IOOP_Database.mdf;Integrated Security=True";
        public DataTable GetAllHalls()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Hall_ID, Capacity, Availability FROM Halls"; // Explicitly include HallID
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public DataTable GetHallByID(int hallID)
        {
            string query = "SELECT * FROM Halls WHERE Hall_ID = @Hall_ID"; // Ensure correct column name
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Hall_ID", hallID);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }


        public void AddHall(int capacity)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Halls (Capacity, Availability) VALUES (@Capacity, 'Available'); SELECT SCOPE_IDENTITY();";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Capacity", capacity);

                conn.Open();
                int newHallID = Convert.ToInt32(cmd.ExecuteScalar()); // Get the new auto-generated HallID
                conn.Close();

                MessageBox.Show($"Hall added successfully! Assigned Hall ID: {newHallID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void EditHall(int hallID, int capacity, string availability)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Halls SET Capacity = @Capacity, Availability = @Availability WHERE Hall_ID = @Hall_ID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Hall_ID", hallID);
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
                string query = "DELETE FROM Halls WHERE Hall_ID = @Hall_ID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Hall_ID", hallID);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
