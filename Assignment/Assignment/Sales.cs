using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Sales
    {
        string connection_string = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ranja\\Source\\Repos\\IOOP_2025_Assignment\\Assignment\\Assignment\\IOOP_Database.mdf;Integrated Security=True";
        string Year;
        string Month;


        public Sales(string month, string year)
        {
           this.Year = year;    
           this.Month = month;
        }

        public int view_sales()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connection_string))
            {
                sqlConnection.Open();
                string query = $"SELECT SUM(Amount) FROM  Orders_Table WHERE  MONTH(Date) = {Month} AND YEAR(Date) = {Year};";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Clear();
                try
                {
                    int total = (int)sqlCommand.ExecuteScalar();
                    return total;
                }
                catch
                {
                    int total = 0;
                    return total;
                }
                
            }
        }

        public int view_total_orders()
        {
            using (SqlConnection con = new SqlConnection(connection_string))
            {
                con.Open();
                string query = $"SELECT COUNT(*) FROM Orders_Table WHERE MONTH(Date) = {Month} AND YEAR(Date) = {Year}";
                SqlCommand sqlCommand = new SqlCommand( query, con);
                sqlCommand.Parameters.Clear();
                int total = (int)sqlCommand.ExecuteScalar();
                return total;
            }
        }

        public int view_chef_sales(string chef)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connection_string))
            {
                sqlConnection.Open();
                string query = $"SELECT SUM(Amount) FROM  Orders_Table WHERE  MONTH(Date) = {Month} AND YEAR(Date) = {Year} AND Chef = '{chef}';";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Clear();
                try
                {
                    int total = (int)sqlCommand.ExecuteScalar();
                    return total;
                }
                catch
                {
                    int total = 0;
                    return total;
                }

            }
        }
    }
}
