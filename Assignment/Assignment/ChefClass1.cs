using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class ChefOrders
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ranja\\Source\\Repos\\IOOP_2025_Assignment\\Assignment\\Assignment\\IOOP_Database.mdf;Integrated Security=True";

        public DataTable GetOrders()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Orders_Table";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public bool OrderExists(string orderId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM Orders_Table WHERE Order_ID = @OrderID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@OrderID", orderId);
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
        }

        public DataTable GetOrderDetails(string orderId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Orders_Table WHERE Order_ID = @OrderID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.SelectCommand.Parameters.AddWithValue("@OrderID", orderId);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public void UpdateOrderProgress(string orderId, string progress, string chef)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "UPDATE Orders_Table SET Progress = @Progress, Chef = @Chef WHERE Order_ID = @OrderID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Progress", progress);
                    cmd.Parameters.AddWithValue("@Chef", chef);
                    cmd.Parameters.AddWithValue("@OrderID", orderId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }


}