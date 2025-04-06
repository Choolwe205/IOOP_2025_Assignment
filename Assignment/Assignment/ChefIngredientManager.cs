using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class IngredientManager
    {
        private string _connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ranja\\Source\\Repos\\IOOP_2025_Assignment\\Assignment\\Assignment\\IOOP_Database.mdf;Integrated Security=True";

        public DataTable LoadData()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Ingredients";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public bool AddIngredient(string id, string name, string quantity)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                // Check if Ingredient_ID already exists
                string checkQuery = "SELECT COUNT(*) FROM Ingredients WHERE Ingredient_ID = @id";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@id", id);

                int count = (int)checkCmd.ExecuteScalar();
                if (count > 0) return false; // ID already exists

                // Insert new ingredient
                string insertQuery = "INSERT INTO Ingredients (Ingredient_ID, Ingredient_Name, Quantity) VALUES (@id, @name, @qty)";
                SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("@id", id);
                insertCmd.Parameters.AddWithValue("@name", name);
                insertCmd.Parameters.AddWithValue("@qty", quantity);

                insertCmd.ExecuteNonQuery();
                return true;
            }
        }

        public bool UpdateIngredient(string id, string name, string quantity)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                // Check if the Ingredient_ID exists
                string checkQuery = "SELECT COUNT(*) FROM Ingredients WHERE Ingredient_ID = @id";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@id", id);

                int count = (int)checkCmd.ExecuteScalar();
                if (count == 0) return false; // ID does not exist

                // Update ingredient
                string updateQuery = "UPDATE Ingredients SET Ingredient_Name = @name, Quantity = @qty WHERE Ingredient_ID = @id";
                SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                updateCmd.Parameters.AddWithValue("@id", id);
                updateCmd.Parameters.AddWithValue("@name", name);
                updateCmd.Parameters.AddWithValue("@qty", quantity);

                updateCmd.ExecuteNonQuery();
                return true;
            }
        }

        public bool DeleteIngredient(string id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                // Check if the Ingredient_ID exists
                string checkQuery = "SELECT COUNT(*) FROM Ingredients WHERE Ingredient_ID = @id";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@id", id);

                int count = (int)checkCmd.ExecuteScalar();
                if (count == 0) return false; // ID does not exist

                // Delete ingredient
                string deleteQuery = "DELETE FROM Ingredients WHERE Ingredient_ID = @id";
                SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn);
                deleteCmd.Parameters.AddWithValue("@id", id);

                deleteCmd.ExecuteNonQuery();
                return true;
            }
        }

        public DataTable SearchIngredient(string name)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Ingredients WHERE Ingredient_Name LIKE @name";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@name", "%" + name + "%");

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}
