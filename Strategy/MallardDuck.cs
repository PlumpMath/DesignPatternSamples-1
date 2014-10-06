using System;

namespace Strategy
{
    public class MallardDuck : Duck
    {
        public MallardDuck() 
        {
            FlyBehavour = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Mallard duck");
        }
    }
}