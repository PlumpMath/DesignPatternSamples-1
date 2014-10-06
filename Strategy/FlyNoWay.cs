using System;

namespace Strategy
{
    public class FlyNoWay : IFlyBehavour
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}