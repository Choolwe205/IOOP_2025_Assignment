using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Xml.Schema;
using System.Threading;
using System.Net;

namespace Assignment
{
    public class Add_users
    {
        string Email { get; set; }
        string Name { get; set; }
        string Password { get; set; }
        string Phone_number { get; set; }


        public Add_users(string email, string name, string password, string phone_number)
        { 
            this.Email = email;
            this.Name = name;   
            this.Password = password;
            this.Phone_number = phone_number;
        }

        //CHECKS VALIDITY OF THE EMAIL
        public string Valid_Email()
        {
            string validity = "valid";
            int space_count = 0;
            
            foreach (char Letter in Email)
            {
                if (Letter.ToString() == " ")
                {
                    space_count += 1;
                }
            }

            if (space_count > 0)
            {
                validity = "Invaid";
                return validity;
            }
            
            
            
            try
            {
                string domain = Email.Split('@')[1];
                var host = Dns.GetHostEntry(domain);
                if (host != null)
                {
                    validity = "valid";
                    return validity;
                }
                else
                {
                    return validity = "Invalid";
                }
            }
            catch (Exception)
            {
                return validity = "Invalid";
            }
        }


        //CHECKS IF THE NAME HAS BEEN ENTERED
        public string Name_check()
        {
            if (Name == null)
            {
                return "null";
            }
            else
            {
                return "not null";
            }
        }


        //CHECKS THE VALIDITY OF THE PASSWORD
        public string Secure_password()
        {
            string security = "weak";
            int numbers_count = 0;
            int special_characters_count = 0;
            int space_count = 0;
            int letters_count = 0;

            foreach (char word in Password)
            {
                letters_count += 1; 
                if (word.ToString() == " ")
                {
                    space_count += 1;
                    return "Has spaces";
                }
                else
                {
                    try
                    {
                        int.Parse(word.ToString());
                        numbers_count += 1;
                    }
                    catch (Exception ex)
                    {
                          
                    }

                    if (word.ToString() == "#" ||  word.ToString() == "*" || word.ToString() == "$" || word.ToString() == "@"
                        || word.ToString() == "!" || word.ToString() == "%")
                    {
                        special_characters_count += 1;
                    }
                }
            }
            if (letters_count < 7)
            {
                return "Password too Short";
            }
            else if (special_characters_count > 0 && numbers_count > 0)
            {
                security = "strong";
            }
            return security;
        }

        //CHECKS THE VALIDITY OF THE PHONE NUMBER
        public string valid_number()
        {
            string validity = "invalid";
            int count = 0;
            if (Phone_number == "")
            {
                return validity;
            }

            try
            {
                int.Parse(Phone_number);
                count = count + 1; 
            }
            catch (Exception ex)
            {
                count = 0;
            }

            if (count > 0)
            {
                validity = "valid";
            }
            return validity;
        }


        //CHECK THE DATABASE IF THE USER EXISTS 
        public int Email_existence()
        {
            string connection_string = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ranja\\Source\\Repos\\IOOP_2025_Assignment\\Assignment\\Assignment\\IOOP_Database.mdf;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                connection.Open();
                string row_check_query = "SELECT COUNT(1) FROM Users WHERE Email_ID = @searchString";
                using (SqlCommand command = new SqlCommand(row_check_query, connection))
                {
                    command.Parameters.AddWithValue("@searchString", Email);
                    int count = (int)command.ExecuteScalar();
                    return count;                  
                }
            }
        }

        //ADDS THE CUSTOMER
        public void add_customers()
        {
            string database_connection_string = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ranja\\Source\\Repos\\IOOP_2025_Assignment\\Assignment\\Assignment\\IOOP_Database.mdf;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(database_connection_string))
            {
                connection.Open();
                string insert_query = "INSERT INTO Users (Email_ID, Name, Password, Phone_Number, Roles) VALUES (@Email_ID, @Name, @Password, @Phone_number, @Roles)";
                using (SqlCommand command = new SqlCommand(insert_query, connection))
                {
                    command.Parameters.AddWithValue("@Email_ID", Email);
                    command.Parameters.AddWithValue("@Name", Name);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@Phone_number", Phone_number);
                    command.Parameters.AddWithValue("@Roles", "Customer");
                    command.ExecuteNonQuery();
                }
            }

        }


        //ADDS ADMININSTRATORS
        public void add_admin()
        {
            string database_connection_string = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ranja\\Source\\Repos\\IOOP_2025_Assignment\\Assignment\\Assignment\\IOOP_Database.mdf;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(database_connection_string))
            {
                connection.Open();
                string insert_query = "INSERT INTO Users (Email_ID, Name, Password, Phone_Number, Roles) VALUES (@Email_ID, @Name, @Password, @Phone_number, @Roles)";
                using (SqlCommand command = new SqlCommand(insert_query, connection))
                {
                    command.Parameters.AddWithValue("@Email_ID", Email);
                    command.Parameters.AddWithValue("@Name", Name);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@Phone_number", Phone_number);
                    command.Parameters.AddWithValue("@Roles", "Admin");
                    command.ExecuteNonQuery();
                }
            }

        }

        //ADDS MANAGERS 
        public void add_manager()
        {
            string database_connection_string = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ranja\\Source\\Repos\\IOOP_2025_Assignment\\Assignment\\Assignment\\IOOP_Database.mdf;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(database_connection_string))
            {
                connection.Open();
                string insert_query = "INSERT INTO Users (Email_ID, Name, Password, Phone_Number, Roles) VALUES (@Email_ID, @Name, @Password, @Phone_number, @Roles)";
                using (SqlCommand command = new SqlCommand(insert_query, connection))
                {
                    command.Parameters.AddWithValue("@Email_ID", Email);
                    command.Parameters.AddWithValue("@Name", Name);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@Phone_number", Phone_number);
                    command.Parameters.AddWithValue("@Roles", "Manager");
                    command.ExecuteNonQuery();
                }
            }

        }

    }
}
