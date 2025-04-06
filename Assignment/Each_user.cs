using System;

public class Each_User
{
    int count;

	public Each_User()
	{

	}

	public void number_of_rows(string role)
	{
        string connection_string = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ranja\\Source\\Repos\\IOOP_2025_Assignment\\Assignment\\Assignment\\IOOP_Database.mdf;Integrated Security=True";
        using (SqlConnection connection = new SqlConnection(connection_string))
        {
            connection.Open();
            string query = $"SELECT COUNT(*) FROM Users WHERE Roles = '{ role }'";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Clear();
                count = (int)command.ExecuteScalar();

            }

            connection.Close();
        }
    }

    public void display_user(string role)
    {
        int count_2 = 1;
        Admin_users[] admin_Users = new Admin_users[count + 1];
        string username;
        while (count_2 <= (count))
        {

            using (SqlConnection connection_2 = new SqlConnection(connection_string))
            {
                connection_2.Open();
                string query_2 = $"SELECT Email_ID FROM Users WHERE Roles = ' {role} ' ORDER BY Email_ID OFFSET " + (count_2 - 1).ToString() + " ROWS FETCH NEXT 1 ROWS ONLY";
                using (SqlCommand command_2 = new SqlCommand(query_2, connection_2))
                {
                    command_2.Parameters.Clear();
                    username = (string)command_2.ExecuteScalar();
                }
            }

            admin_Users[count_2] = new Admin_users();
            admin_Users[count_2].user_username = username;
            flowLayoutPanel1.Controls.Add(admin_Users[count_2]);

            count_2 += 1;
        }
    }

}
