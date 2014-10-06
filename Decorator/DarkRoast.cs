namespace Decorator
{
    public class DarkRoast : Beverage
    {
        public override string Description
        {
            get { return "Dark Roast"; }
        }

        public override double Cost
        {
            get { return .75; }
        }
    }
}