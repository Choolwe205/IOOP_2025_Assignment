using System;
using System.Data.SqlClient;

namespace Assignment
{
    public class ViewOrderClass
    {
        private string Order_ID;
        private string database_connection_string = @"Data Source=(LocalDB)\MSSQLLocalDB; 
    AttachDbFilename=C:\Users\HP 15\OneDrive - Asia Pacific University\Documents\GitHub\IOOP_2025_Assignment\Assignment\Assignment\IOOP_Database.mdf; 
    Integrated Security=True;";

        public ViewOrderClass(string order_id)
        {
            this.Order_ID = order_id;
        }

        // Method for verifying an order by checking email_ID and Order_ID
        public bool VerifyOrderCustomer(string order_ID, string email_ID)
        {
            bool exists = false;

            using (SqlConnection conn = new SqlConnection(database_connection_string))
            {
                string query = "SELECT COUNT(*) FROM Orders_Table WHERE Order_ID = @Order_ID AND Email_ID = @Email_ID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Order_ID", order_ID);
                    cmd.Parameters.AddWithValue("@Email_ID", email_ID);

                    try
                    {
                        conn.Open();
                        int count = (int)cmd.ExecuteScalar(); // Get the count of matching rows
                        exists = count > 0;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Database error: " + ex.Message); // Logs the error
                    }
                }
            }

            return exists;
        }


        // Method to show order details
        public string ShowCustomerOrder(string orderId)
        {
            if (string.IsNullOrEmpty(orderId))
            {
                return "Invalid Order ID.";
            }

            string result = "";

            using (SqlConnection conn = new SqlConnection(database_connection_string))
            {
                conn.Open();
                string query = "SELECT Food_ID, Order_ID, Amount FROM OrderFood WHERE Order_ID = @Order_ID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Order_ID", orderId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            result = $"Food ID: {reader["Food_ID"]}\n" +
                                     $"Order ID: {reader["Order_ID"]}\n" +
                                     $"Amount: {reader["Amount"]}";
                        }
                        else
                        {
                            result = "No order found.";
                        }
                    }
                }
            }

            return result;
        }
    }
}
