using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Assignment.Manager
{
    public class MenuManager
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\CYBORG\source\repos\IOOP_2025_Assignment\Assignment\Assignment\IOOP_Database.mdf;Integrated Security=True";

        public DataTable GetAllMenuItems()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT FoodID, Description, Price FROM Menu"; // Explicitly select columns
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public bool AddMenuItem(string description, decimal price)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Menu (Description, Price) VALUES (@Description, @Price)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Description", description);
                cmd.Parameters.AddWithValue("@Price", price);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery(); // Returns number of rows inserted
                conn.Close();

                return rowsAffected > 0; // Returns true if insertion was successful
            }
        }


        public void UpdateMenuItem(int foodID, string description, decimal price)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Menu SET Description = @Description, Price = @Price WHERE FoodID = @FoodID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FoodID", foodID);
                cmd.Parameters.AddWithValue("@Description", description);
                cmd.Parameters.AddWithValue("@Price", price);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void DeleteMenuItem(int foodID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Menu WHERE FoodID = @FoodID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FoodID", foodID);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
