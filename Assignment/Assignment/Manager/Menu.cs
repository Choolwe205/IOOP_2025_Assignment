namespace Assignment.Manager
{
    public class Menu
    {
        public string Food_ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public byte[] Picture { get; set; } 

        public Menu(string foodID, string description, decimal price, byte[] image)
        {
            Food_ID = foodID;
            Description = description;
            Price = price;
            Picture = image;
        }
    }
}
