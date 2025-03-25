using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Make_Reservation
    {
        string Email { get; set; }
        string Date { get; set; }
        string Special_Request { get; set; }
        int Capacity { get; set; }
        string type { get; set; }

        public Make_Reservation(string Email, string Date, string Special_Request, int Capacity, string type)
        {
            this.Email = Email;
            this.Date = Date;
            this.Special_Request = Special_Request;
            this.Capacity = Capacity;
            this.type = type;
        }

        public void CustomerRequestReservation()
        {
            using (SqlConnection connection1=new SqlConnection ("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\HP 15\\Source\\Repos\\IOOP_2025_Assignment\\Assignment\\Assignment\\IOOP_Database.mdf\";Integrated Security=True") )
            {
                connection1.Open ();
                using (SqlCommand command1 = new SqlCommand("INSERT INTO request values   ",connection1);
            }
        }
    }
}
