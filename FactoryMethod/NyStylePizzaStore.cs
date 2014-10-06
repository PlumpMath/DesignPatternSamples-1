namespace FactoryMethod
{
    public class NyStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "Cheese":
                    return new NyStyleCheesePizza();
                case "Veggie":
                    return new NyStyleVeggiePizza();
                default:
                    return null;
            }
        }
    }
}