using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Assignment
{
    internal class Verifying
    {

        public Verifying()
        {

        }


        public int verifying_reservation_ID(string Reservation_ID)
        {
            string connection_string = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hp\\Source\\Repos\\IOOP_2025_Assignment\\Assignment\\Assignment\\IOOP_Database.mdf;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                connection.Open();
                string row_check_query = "SELECT COUNT(1) FROM Reservations WHERE Reservation_ID = @searchString";
                using (SqlCommand command = new SqlCommand(row_check_query, connection))
                {
                    command.Parameters.AddWithValue("@searchString", Reservation_ID);
                    int count = (int)command.ExecuteScalar();
                    return count;


                }


            }

            
        }

    }
}
