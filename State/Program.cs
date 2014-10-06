using System;

namespace State
{
    class Program
    {
        static void Main()
        {
            GumballMachine gumballMachine = new GumballMachine();

            gumballMachine.InsertQuarter();
            gumballMachine.EjectQuarter();
            gumballMachine.TurnCrank();

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.Dispense();

            Console.ReadLine();
        }
    }
}
