using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment.Manager
{
    public class MenuManager
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ranja\Source\Repos\IOOP_2025_Assignment\Assignment\Assignment\IOOP_Database.mdf;Integrated Security=True";

        private byte[] ImageToByteArray(string imagePath)
        {
            if (string.IsNullOrEmpty(imagePath) || !File.Exists(imagePath))
                return null;

            return File.ReadAllBytes(imagePath); // Reads the file as a byte array
        }

        public Image LoadImage(byte[] imageData)
        {
            if (imageData == null || imageData.Length == 0)
                return null;

            using (MemoryStream ms = new MemoryStream(imageData))
            {
                return Image.FromStream(ms);
            }
        }
        public DataTable GetAllMenuItems()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Food_Id, Description, Price, Picture FROM Menu";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
        }


        public bool AddMenuItem(string Food_Id, string description, decimal price, byte[] imageBytes)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Menu (Food_Id, Description, Price, Picture) VALUES (@Food_Id, @Description, @Price, @Picture)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Food_Id", Food_Id);
                    cmd.Parameters.AddWithValue("@Description", description);
                    cmd.Parameters.AddWithValue("@Price", price);

                    if (imageBytes != null)
                        cmd.Parameters.AddWithValue("@Picture", imageBytes);
                    else
                        cmd.Parameters.Add("@Picture", SqlDbType.Image).Value = DBNull.Value;

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }


        public bool UpdateMenuItem(string Food_Id, string description, decimal price, byte[] imageBytes)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Menu SET Description = @Description, Price = @Price, Picture = @Picture WHERE Food_Id = @Food_Id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Food_Id", Food_Id);
                    cmd.Parameters.AddWithValue("@Description", description);
                    cmd.Parameters.AddWithValue("@Price", price);

                    if (imageBytes != null)
                        cmd.Parameters.AddWithValue("@Picture", imageBytes);
                    else
                        cmd.Parameters.Add("@Picture", SqlDbType.Image).Value = DBNull.Value;

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }




        public bool DeleteMenuItem(string Food_Id) // Change Food_Id to string
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Menu WHERE Food_Id = @Food_Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Food_Id", Food_Id); // Keep Food_Id as string

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                return rowsAffected > 0;
            }
        }

    }
}
