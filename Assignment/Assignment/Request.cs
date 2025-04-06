using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Assignment
{
    class Request
    {
        // Properties
        public string event_type { get; set; }
        public int capacity { get; set; }
        public DateTime reservationdate { get; set; }
        public string special_Request { get; set; }
        public DateTime start_time { get; set; }
        public DateTime end_time { get; set; }
        public string additional_request { get; set; }
        public string approval = "not approved";
        public string messagefromcoord { get; set; }
        public string Email { get; set; }  // Customer's email

        // Constructor updated to include Email.
        public Request(string Event, int Capacity, string Special_Request, DateTime Reservationdate, string Additional_request, DateTime Start_time, DateTime End_time, string email)
        {
            this.event_type = Event;
            this.capacity = Capacity;
            this.reservationdate = Reservationdate;
            this.additional_request = Additional_request;
            this.start_time = Start_time;
            this.end_time = End_time;
            this.special_Request = Special_Request;
            this.Email = email;
        }

        // Add customer request to the database.
        public void add_customers()
        {
            string database_connection_string = @"Data Source=(LocalDB)\MSSQLLocalDB; 
AttachDbFilename=C:\Users\HP 15\OneDrive - Asia Pacific University\Documents\GitHub\IOOP_2025_Assignment\Assignment\Assignment\IOOP_Database.mdf; 
Integrated Security=True;";

            try
            {
                using (SqlConnection connection = new SqlConnection(database_connection_string))
                {
                    connection.Open();
                    string insert_query = "INSERT INTO Requests (Type_of_event, Number_Of_People, Special_Requests, Start_Date, Additional_additions, Start_time, End_time, Approval, Email_ID) " +
                        "VALUES (@Type_of_event, @Number_of_People, @Special_Requests, @Start_Date, @Additional_additions, @Start_Time, @End_Time, @Approval, @Email_ID); " +
                        "SELECT SCOPE_IDENTITY();"; // Retrieve the inserted Request ID

                    using (SqlCommand command = new SqlCommand(insert_query, connection))
                    {
                        command.Parameters.AddWithValue("@Type_of_event", event_type);
                        command.Parameters.AddWithValue("@Number_of_People", capacity);
                        command.Parameters.AddWithValue("@Special_Requests", special_Request);
                        command.Parameters.AddWithValue("@Approval", approval);
                        command.Parameters.AddWithValue("@Start_Date", reservationdate);
                        command.Parameters.AddWithValue("@Start_Time", start_time);
                        command.Parameters.AddWithValue("@End_Time", end_time);
                        command.Parameters.AddWithValue("@Additional_additions", additional_request);
                        command.Parameters.AddWithValue("@Email_ID", Email);

                        // Execute and get the inserted ID.
                        int requestId = Convert.ToInt32(command.ExecuteScalar());
                        MessageBox.Show($"Request Made! Your Request ID is: {requestId}. Please wait for approval.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Show customer request details from the database.
        public string Show_Request(string Request_ID)
        {
            string result = "";
            string database_connection_string = @"Data Source=(LocalDB)\MSSQLLocalDB; 
AttachDbFilename=C:\Users\HP 15\OneDrive - Asia Pacific University\Documents\GitHub\IOOP_2025_Assignment\Assignment\Assignment\IOOP_Database.mdf; 
Integrated Security=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(database_connection_string))
                {
                    conn.Open();
                    // Ensure that the request belongs to this Email.
                    string query = "SELECT Request_ID, Type_of_event, Number_Of_People, Special_Requests, Start_Date, Additional_additions, Start_time, End_time, Approval " +
                                   "FROM Requests WHERE Request_ID = @Request_ID AND Email_ID = @Email_ID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Request_ID", Request_ID);
                        cmd.Parameters.AddWithValue("@Email_ID", Email);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                result = $"Request ID: {reader["Request_ID"]}\n" +
                                         $"Event Type: {reader["Type_of_event"]}\n" +
                                         $"Number of People: {reader["Number_Of_People"]}\n" +
                                         $"Special Requests: {reader["Special_Requests"]}\n" +
                                         $"Start Date: {reader["Start_Date"]}\n" +
                                         $"Additional Requests: {reader["Additional_additions"]}\n" +
                                         $"Start Time: {reader["Start_time"]}\n" +
                                         $"End Time: {reader["End_time"]}\n" +
                                         $"Approval: {reader["Approval"]}";
                            }
                            else
                            {
                                result = "No request found.";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
    }
}
