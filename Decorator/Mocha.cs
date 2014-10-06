namespace Decorator
{
    public class Mocha : Condiment
    {
        public Mocha(Beverage beverage)
            : base(beverage) 
        {
        }

        public override string Description
        {
            get { return Beverage.Description + ", Mocha"; }
        }

        public override double Cost
        {
            get { return Beverage.Cost + .25; }
        }
    }
}