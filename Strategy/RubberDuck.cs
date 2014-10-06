using System;

namespace Strategy
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            FlyBehavour = new FlyNoWay();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Model duck");
        }
    }
}