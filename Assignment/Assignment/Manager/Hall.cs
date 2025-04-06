namespace Assignment.Manager
{
    public class Hall
    {
        public int Hall_ID { get; set; }
        public int Capacity { get; set; }
        public string Availability { get; set; }

        public Hall(int hallID, int capacity, string availability)
        {
            Hall_ID = hallID;
            Capacity = capacity;
            Availability = availability;
        }
    }
}
