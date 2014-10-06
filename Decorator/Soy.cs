namespace Decorator
{
    public class Soy : Condiment
    {
        public Soy(Beverage beverage)
            : base(beverage) 
        {
        }

        public override string Description
        {
            get { return Beverage.Description + ", Soy"; }
        }

        public override double Cost
        {
            get { return Beverage.Cost + .25; }
        }
    }
}