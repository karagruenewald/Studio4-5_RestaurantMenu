using System;

namespace RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu firstMenu = new Menu();
            //firstMenu.StartDate = new DateTime();
            firstMenu.StartDate = DateTime.Now;

            Console.WriteLine(firstMenu.StartDate);
        }
    }
}
