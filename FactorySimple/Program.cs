using System;

namespace FactorySimple
{
    class Program
    {
        static void Main()
        {
            PizzaFactory factory = new PizzaFactory();

            Pizza pizza = factory.CreatePizza("Veggie");
            Console.WriteLine("Created {0}", pizza.Description);

            pizza = factory.CreatePizza("Cheese");
            Console.WriteLine("Created {0}", pizza.Description);

            Console.ReadLine();
        }
    }
}
