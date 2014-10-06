using System;

namespace Iterator
{
    class Program
    {
        static void Main()
        {
            BreakfastMenu breakfastMenu = new BreakfastMenu();

            foreach (MenuItem item in breakfastMenu)
            {
                item.Display();
            }

            Console.ReadLine();
        }
    }
}
