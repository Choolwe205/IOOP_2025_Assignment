using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Assignment
{
     

    internal class Each_User_class
    {
        int count;

        public int number_of_rows(string table)
        {
            string connection_string = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ranja\\Source\\Repos\\IOOP_2025_Assignment\\Assignment\\Assignment\\IOOP_Database.mdf;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                connection.Open();
                string query = $"SELECT COUNT(*) FROM {table}";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Clear();
                    count = (int)command.ExecuteScalar();

                }

                connection.Close();
            }
            return count;
        }

        public string side_content(string table, string row, string Email)
        {
            string connection_string = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ranja\\Source\\Repos\\IOOP_2025_Assignment\\Assignment\\Assignment\\IOOP_Database.mdf;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                connection.Open();
                string query = $"SELECT {row} FROM {table} WHERE Email_ID = '{Email}'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Clear();
                    string return_statement = (string)command.ExecuteScalar();
                    return return_statement;

                }
            }
        }


        public string Display_general_users(string table_name, int count)
        {
            string username;
            string connection_string = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ranja\\Source\\Repos\\IOOP_2025_Assignment\\Assignment\\Assignment\\IOOP_Database.mdf;Integrated Security=True";
            using (SqlConnection connection_2 = new SqlConnection(connection_string))
            {
                connection_2.Open();
                string query_table = $"SELECT Email_ID FROM {table_name} ORDER BY Email_ID OFFSET " + (count - 1).ToString() + " ROWS FETCH NEXT 1 ROWS ONLY";
                SqlCommand new_command = new SqlCommand(query_table, connection_2);
                username = (string)new_command.ExecuteScalar();
                connection_2.Close();
            }
            return username;
        }


        public string display_user(string role, int count_2)
        { 
            string username;
            string role_db;
            string connection_string = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ranja\\Source\\Repos\\IOOP_2025_Assignment\\Assignment\\Assignment\\IOOP_Database.mdf;Integrated Security=True";
            using (SqlConnection connection_2 = new SqlConnection(connection_string))
            {
                connection_2.Open();
                string query_2 = "SELECT Email_ID FROM Users ORDER BY Email_ID OFFSET " + (count_2 - 1).ToString() + " ROWS FETCH NEXT 1 ROWS ONLY";
                string query_3 = "SELECT Roles FROM Users ORDER BY Email_ID OFFSET " + (count_2 - 1).ToString() + " ROWS FETCH NEXT 1 ROWS ONLY";
                SqlCommand command_2 = new SqlCommand(query_2, connection_2);
                username = (string)command_2.ExecuteScalar();
                SqlCommand command_3 = new SqlCommand(query_3, connection_2);
                role_db = (string)command_3.ExecuteScalar();
                connection_2.Close();
            }


            if (role_db == role)
            {
                return username; 
            }
            else
            {
                return "NOT IN ROLE";
            }
        }
    }
}

    

