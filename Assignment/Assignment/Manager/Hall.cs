﻿namespace Assignment.Manager
{
    public class Hall
    {
        public int HallID { get; set; }
        public int Capacity { get; set; }
        public string Availability { get; set; }

        public Hall(int hallID, int capacity, string availability)
        {
            HallID = hallID;
            Capacity = capacity;
            Availability = availability;
        }
    }
}
