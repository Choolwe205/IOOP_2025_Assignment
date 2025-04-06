namespace Assignment.Manager
{
    public class Menu
    {
        public string FoodID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Menu(string foodID, string description, decimal price)
        {
            FoodID = foodID;
            Description = description;
            Price = price;
        }
    }
}
