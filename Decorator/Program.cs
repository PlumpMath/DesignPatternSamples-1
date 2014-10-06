using System;

namespace Decorator
{
    class Program
    {
        static void Main()
        {
            Beverage coffee = new DarkRoast();
            coffee = new Mocha(coffee);
            coffee = new Mocha(coffee);
            coffee = new Soy(coffee);

            Console.WriteLine("{0} {1}", coffee.Description, coffee.Cost);

            coffee = new HouseBlend();
            coffee = new Soy(coffee);

            Console.WriteLine("{0} {1}", coffee.Description, coffee.Cost);

            Console.ReadLine();
        }
    }
}
