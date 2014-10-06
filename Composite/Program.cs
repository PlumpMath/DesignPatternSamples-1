using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuComponent dinerMenu = new Menu("Diner Menu");
            MenuComponent breakfastMenu = new Menu("Breakfast Menu");
            MenuComponent lunchMenu = new Menu("Lunch Menu");

            dinerMenu.Add(breakfastMenu);
            
            breakfastMenu.Add(new MenuItem("Pancakes", "Decilious pancakes", 1.99));
            breakfastMenu.Add(new MenuItem("Waffles", "Yummy waffles", 2.50));
            breakfastMenu.Add(new MenuItem("Toast", "Perfect toast", 2.50));

            dinerMenu.Add(lunchMenu);

            lunchMenu.Add(new MenuItem("Soup of the Day", "Soup of the day, with a side of potato salad", 3.50));
            lunchMenu.Add(new MenuItem("Hot Dog", "A hot dog with onions and ketchup", 3.75));
            lunchMenu.Add(new MenuItem("BLT", "A bacon, lettice and tomato sandwich", 3.00));

            dinerMenu.Display();

            Console.ReadLine();
        }
    }
}
