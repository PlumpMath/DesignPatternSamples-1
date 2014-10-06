namespace Decorator
{
    public class HouseBlend : Beverage
    {
        public override string Description
        {
            get { return "House Blend"; }
        }

        public override double Cost
        {
            get { return .50; }
        }
    }
}