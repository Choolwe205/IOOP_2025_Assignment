using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Assignment
{
    class Request
    {
        string event_type { get; set; }
        int capacity    { get; set; } 
        string hall_type { get; set; }
        DateTime reservationdate { get; set; }
        string additional_request {  get; set;}
    

        Request( string Event, int Capacity, string Hall_type, DateTime Reservationdate, string Additional_request)
        {
            this.event_type = Event;
            this.capacity = Capacity;
            this.hall_type = Hall_type;
            this.reservationdate = Reservationdate;
            this.additional_request = Additional_request;
        }

        //    public void add_customers()
        //    {
        //        string database_connection_string =Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="C:\Users\HP 15\OneDrive - Asia Pacific University\Documents\GitHub\IOOP_2025_Assignment\Assignment\Assignment\IOOP_Database.mdf";Integrated Security=True
        //        using (SqlConnection connection = new SqlConnection(database_connection_string))
        //        {
        //            connection.Open();
        //            string insert_query = "INSERT INTO Users (Event, Capacity, Hall_Type , Reservationdate , Additional_request) VALUES (@Email_ID, @Name, @Password, @Phone_number, @Roles)";
        //            using (SqlCommand command = new SqlCommand(insert_query, connection))
        //            {
        //                command.Parameters.AddWithValue("@Email_ID", Email);
        //                command.Parameters.AddWithValue("@Name", Name);
        //                command.Parameters.AddWithValue("@Password", Password);
        //                command.Parameters.AddWithValue("@Phone_number", Phone_number);
        //                command.Parameters.AddWithValue("@Roles", "Customer");
        //                command.ExecuteNonQuery();
        //            }
        //        }

        //    }






    }


}
