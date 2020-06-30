using System;
namespace RestaurantMenu
{
    public class MenuItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool NewItem { get; set; }


        public MenuItem(string name, double price, string description, string category, bool newItem)
        {
            Name = name;
            Price = price;
            Description = description;
            Category = category;
            NewItem = newItem;
        }
    }
}
