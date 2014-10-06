using System;

namespace Strategy
{
    class Program
    {
        static void Main()
        {
            Duck duck = new MallardDuck();
            duck.Display();
            duck.PerformFly();
            duck.PerformSwim();

            duck = new RubberDuck();
            duck.Display();
            duck.PerformFly();
            duck.PerformSwim();
            
            Console.ReadLine();
        }
    }
}
