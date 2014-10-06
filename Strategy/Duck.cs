using System;

namespace Strategy
{
    public abstract class Duck
    {
        protected IFlyBehavour FlyBehavour;

        public void PerformFly()
        {
            FlyBehavour.Fly();
        }

        public void PerformSwim()
        {
            Console.WriteLine("All ducks can swim");
        }

        public abstract void Display();
    }
}
