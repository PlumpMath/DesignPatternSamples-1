namespace FactoryAbstract
{
    public abstract class Pizza
    {
        protected readonly IPizzaIngredientFactory PizzaIngredientFactory;

        protected Pizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            PizzaIngredientFactory = pizzaIngredientFactory;
        }

        public abstract void Prepare();
    }
}
