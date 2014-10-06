using System;

namespace Command
{
    class Program
    {
        static void Main()
        {
            RemoteControl remote = new RemoteControl();

            Lights lights = new Lights();
            ICommand command1 = new TurnLightsOn(lights);
            ICommand command2 = new TurnLightsOff(lights);

            remote.SetButton(0, command1);
            remote.PressButton(0);
            
            remote.SetButton(0, command2);
            remote.PressButton(0);

            Console.ReadLine();
        }
    }
}
