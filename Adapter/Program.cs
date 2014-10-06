using System;

namespace Adapter
{
    class Program
    {
        static void Main()
        {
            IDuck duck = new MallardDuck();
            duck.Quack();
            duck.Fly();

            ITurkey turkey = new WildTurkey();
            turkey.Gobble();
            turkey.Fly();

            IDuck adapter = new DuckAdapter(turkey);
            adapter.Quack();
            adapter.Fly();

            Console.ReadLine();
        }
    }
}