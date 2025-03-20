using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Assignment
{
    internal class Login
    {
        string Email;
        string Password;

        public Login(string email, string password)
        {
            this.Email = email;
            this.Password = password;
        }

        //CHECK WHICH PAGE THE USER SHOULD BE TAKEN TO 
        public string Login_algorithm()
        {
            string return_value;


            string connection_string = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ranja\\Source\\Repos\\IOOP_2025_Assignment\\Assignment\\Assignment\\IOOP_Database.mdf;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                connection.Open();
                string row_check_query = "SELECT COUNT(1) FROM Users WHERE Email_ID = @Email";
                using (SqlCommand command = new SqlCommand(row_check_query, connection))
                {
                    command.Parameters.AddWithValue("@Email", Email);
                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        string password_finder_query = "SELECT Password FROM Users WHERE EMAIL_ID = @Email";
                        using (SqlCommand command_1 = new SqlCommand(password_finder_query, connection))
                        {
                            command_1.Parameters.AddWithValue("@Email", Email);
                            string database_password = command_1.ExecuteScalar().ToString();

                            if (database_password == Password)
                            {
                                string role_check_query = "SELECT Roles FROM Users WHERE Email_ID = @Email";
                                using (SqlCommand command_2 = new SqlCommand(role_check_query, connection))
                                {
                                    command_2.Parameters.AddWithValue("@Email", Email);
                                    string role = command_2.ExecuteScalar().ToString();
                                    return role;
                                }
                            }
                            else
                            {
                                return "Invalid Password";
                            }
                        }
                    }
                    else
                    {
                        return return_value = "Doesn't Exist";
                    }
                }
            }
        }


    }
}
