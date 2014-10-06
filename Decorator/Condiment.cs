namespace Decorator
{
    public abstract class Condiment : Beverage
    {
        protected readonly Beverage Beverage;

        protected Condiment(Beverage beverage)
        {
            Beverage = beverage;
        }
    }
}