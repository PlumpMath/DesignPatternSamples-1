namespace FactoryMethod
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "Cheese":
                    return new ChicagoStyleCheesePizza();
                case "Veggie":
                    return new ChicagoStyleVeggiePizza();
                default:
                    return null;
            }
        }
    }
}