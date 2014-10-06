using System;

namespace FactoryAbstract
{
    class Program
    {
        static void Main()
        {
            IPizzaIngredientFactory nyIngredientFactory = new NyPizzaIngredientsFactory();
            Pizza pizza = new CheesePizza(nyIngredientFactory);
            pizza.Prepare();

            IPizzaIngredientFactory chicagoIngredientFactory = new ChicagoPizzaIngredientsFactory();
            pizza = new CheesePizza(chicagoIngredientFactory);
            pizza.Prepare();

            Console.ReadLine();
        }
    }
}
