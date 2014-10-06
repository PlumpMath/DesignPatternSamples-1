using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main()
        {
            PizzaStore nyStore = new NyStylePizzaStore();
            Pizza pizza = nyStore.OrderPizza("Cheese");
            Console.WriteLine("Ordered {0}", pizza.Description);

            PizzaStore chicagoStore = new ChicagoStylePizzaStore();
            pizza = chicagoStore.OrderPizza("Cheese");
            Console.WriteLine("Ordered {0}", pizza.Description);

            Console.ReadLine();
        }
    }
}
