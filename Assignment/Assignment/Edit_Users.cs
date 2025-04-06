using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Edit_Users
    {
        string Email;
        string Name;
        string Password;
        string Phone_Number;
        string connection_string = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ranja\\Source\\Repos\\IOOP_2025_Assignment\\Assignment\\Assignment\\IOOP_Database.mdf;Integrated Security=True";

        public Edit_Users(string email, string name, string password, string phone_Number)
        {
            Email = email;
            Name = name;
            Password = password;
            Phone_Number = phone_Number;
        }


        public void edit_Users()
        {
            int count;
            using (SqlConnection connection =  new SqlConnection(connection_string))
            {
                connection.Open();
                string query = $"UPDATE Users SET Name = '{Name}', Password = '{Password}', Phone_Number = '{Phone_Number}' WHERE Email_ID = '{Email}' ";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();

                }


            }
        }


    }
}
