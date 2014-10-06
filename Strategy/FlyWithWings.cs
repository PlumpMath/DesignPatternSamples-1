using System;

namespace Strategy
{
    public class FlyWithWings : IFlyBehavour
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}