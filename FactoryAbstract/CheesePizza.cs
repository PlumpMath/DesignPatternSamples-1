using System;

namespace FactoryAbstract
{
    public class CheesePizza : Pizza
    {
        public CheesePizza(IPizzaIngredientFactory pizzaIngredientFactory) 
            : base(pizzaIngredientFactory)
        {
        }

        public override void Prepare()
        {
            IDough dough = PizzaIngredientFactory.CreateDough();
            ISauce sauce = PizzaIngredientFactory.CreateSauce();

            Console.WriteLine("Preparing Pizza {0}, {1}", dough.Description, sauce.Description);
        }
    }
}