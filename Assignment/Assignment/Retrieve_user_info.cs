using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Retrieve_user_info
    {
        string email_ID;

        public Retrieve_user_info(string Email_ID)
        {
            this.email_ID = Email_ID;   
        }
        

        public string get_name()
        {
            string Name;

            string connection_string = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ranja\\Source\\Repos\\IOOP_2025_Assignment\\Assignment\\Assignment\\IOOP_Database.mdf;Integrated Security=True";
            using (SqlConnection  connection = new SqlConnection(connection_string))
            {
                connection.Open();
                string query = $"SELECT Name FROM Users WHERE Email_ID = '{email_ID}'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    Name = (string) command.ExecuteScalar();
                }
                connection.Close();
            }
            return Name;
        }

        public string get_password()
        {

            string Password;

            string connection_string = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ranja\\Source\\Repos\\IOOP_2025_Assignment\\Assignment\\Assignment\\IOOP_Database.mdf;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                connection.Open();
                string query = $"SELECT Password FROM Users WHERE Email_ID = '{email_ID}'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    Password = (string)command.ExecuteScalar();
                }
                connection.Close();
            }
            return Password;
        }

        public string get_phonenumber()
        {

            string Phone_number;

            string connection_string = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ranja\\Source\\Repos\\IOOP_2025_Assignment\\Assignment\\Assignment\\IOOP_Database.mdf;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                connection.Open();
                string query = $"SELECT Phone_Number FROM Users WHERE Email_ID = '{email_ID}'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    Phone_number = (string)command.ExecuteScalar();
                }
                connection.Close();
            }
            return Phone_number;
        }

    }
}
