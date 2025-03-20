using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Reservation
    {
         
        private string username;

        public Reservation(string username)
        {
            this.username = username;
        }

        public static DataTable DataValue(string username)
        {
            DataTable dbl = new DataTable();
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Source\Repos\IOOP_2025_Assignment\Assignment\Assignment\IOOP_Database.mdf;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter sqlDB = new SqlDataAdapter("select * from reservation where Customer_username = @username", connection);
                sqlDB.SelectCommand.Parameters.AddWithValue("@username", username);
                sqlDB.Fill(dbl);
            }
            return dbl;
        }

        public static ArrayList showData()
        {
            ArrayList store = new ArrayList();
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Source\Repos\IOOP_2025_Assignment\Assignment\Assignment\IOOP_Database.mdf;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("select Customer_username, Customer_Name from reservation", connection);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    string store1 = $"{rd.GetString(0).TrimEnd()} - {rd.GetString(1).TrimEnd()}";
                    store.Add(store1);
                }

            }

            return store;
        }


    }

}

