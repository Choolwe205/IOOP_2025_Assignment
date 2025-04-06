using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Admin_users : UserControl
    {
        private string username;
        public event Action <string> LoadForm;
        public event Action ReloadForm;


        public string user_username
        {
            get { return username; }
            set { username = value; username_lbl.Text = value; }
        }


        public Admin_users()
        {
            InitializeComponent();
        }

        private void Admin_users_Load(object sender, EventArgs e)
        {

        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            LoadForm?.Invoke(username);
            
            
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            delete_user();
            ReloadForm?.Invoke();
        }

        private void delete_user()
        {
            string connection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ranja\\Source\\Repos\\IOOP_2025_Assignment\\Assignment\\Assignment\\IOOP_Database.mdf;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connection);
            sqlConnection.Open();

            string get_info_query = $"SELECT Order_ID FROM Orders_Table WHERE Email_ID = '{username}'";
            SqlCommand comm = new SqlCommand(get_info_query, sqlConnection);
            string order = (string)comm.ExecuteScalar();


            string delete_query_users = $"DELETE FROM Users WHERE Email_ID = '{username}'";
            string delete_query_rescord = $"DELETE FROM Reservations WHERE Email_ID = '{username}'";
            string delete_query_request = $"DELETE FROM Requests WHERE Email_ID = '{username}'";
            string delete_orders = $"DELETE FROM Order_Details WHERE Order_ID = '{order}'";
            string delete_order_again = $"DELETE FROM OrderFood WHERE Order_ID = '{order}'";
            string delete_query_order = $"DELETE FROM Orders_Table WHERE Email_ID = '{username}'";
            string delete_query_feedback = $"DELETE FROM Feedback_Table WHERE Email_ID = '{username}'";
            SqlCommand command_5 = new SqlCommand(delete_orders, sqlConnection);
            SqlCommand command_6 = new SqlCommand(delete_order_again, sqlConnection);
            SqlCommand command_1 = new SqlCommand(delete_query_rescord, sqlConnection);
            SqlCommand command_2 = new SqlCommand(delete_query_request, sqlConnection);
            SqlCommand command_3 = new SqlCommand(delete_query_order, sqlConnection);
            SqlCommand command_4 = new SqlCommand(delete_query_feedback, sqlConnection);
            SqlCommand command = new SqlCommand(delete_query_users, sqlConnection);
            command_5.ExecuteNonQuery();
            command_6.ExecuteNonQuery();
            command_1.ExecuteNonQuery();
            command_2.ExecuteNonQuery();
            command_3.ExecuteNonQuery();
            command_4.ExecuteNonQuery();
            command.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}

