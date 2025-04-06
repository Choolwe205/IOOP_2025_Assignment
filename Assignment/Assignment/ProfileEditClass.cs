using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class ProfileEditClass
    {
        string Email_ID;
        string Name;
        string Phone_Number;


        private string database_connection_string = @"Data Source=(LocalDB)\MSSQLLocalDB; 
    AttachDbFilename=C:\Users\HP 15\OneDrive - Asia Pacific University\Documents\GitHub\IOOP_2025_Assignment\Assignment\Assignment\IOOP_Database.mdf; 
    Integrated Security=True;";



        public ProfileEditClass(string email_id, string Name, string phone_number)
        {
            this.Email_ID = email_id;
            this.Name = Name;
            this.Phone_Number = phone_number;
        }
        public string ViewProfileDetails(string Email_id) 
        {
            string result = "";

            using (SqlConnection conn = new SqlConnection(database_connection_string))
            {
                conn.Open();
                string query = "SELECT Email_id,Name,Phone_Number FROM Users WHERE Email_id = @Email_id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email_ID", Email_id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            result = $"Email: {reader["Email_ID"]}\n" +
                                     $"Name: {reader["Name"]}\n" +
                                     $"Phone Number: {reader["Phone_Number"]}";
                        }
                        else
                        {
                            result = "User Not Found.";
                        }
                    }
                }
            }

            return result;
        }
    }
}
