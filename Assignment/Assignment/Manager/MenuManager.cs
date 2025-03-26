using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Assignment.Manager
{
    public class MenuManager
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ranja\Source\Repos\IOOP_2025_Assignment\Assignment\Assignment\IOOP_Database.mdf;Integrated Security=True";

        public DataTable GetAllMenuItems()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT FoodID, Description, Price FROM Menu";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
        }



        public bool AddMenuItem(string foodID, string description, decimal price)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Menu (FoodID, Description, Price) VALUES (@FoodID, @Description, @Price)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FoodID", foodID);
                cmd.Parameters.AddWithValue("@Description", description);
                cmd.Parameters.AddWithValue("@Price", price);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery(); // Returns number of rows inserted
                conn.Close();

                return rowsAffected > 0; // Returns true if insertion was successful
            }
        }



        public bool UpdateMenuItem(string foodID, string description, decimal price) // Change foodID to string
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Menu SET Description = @Description, Price = @Price WHERE FoodID = @FoodID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FoodID", foodID); // Keep FoodID as string
                cmd.Parameters.AddWithValue("@Description", description);
                cmd.Parameters.AddWithValue("@Price", price);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                return rowsAffected > 0;
            }
        }

        public bool DeleteMenuItem(string foodID) // Change foodID to string
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Menu WHERE FoodID = @FoodID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FoodID", foodID); // Keep FoodID as string

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                return rowsAffected > 0;
            }
        }

    }
}
