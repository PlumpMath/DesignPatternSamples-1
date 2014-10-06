namespace FactorySimple
{
    public class PizzaFactory
    {
        public Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "Veggie":
                    return new VeggiePizza();
                case "Cheese":
                    return new CheesePizza();
                default:
                    return null;
            }
        }
    }
}