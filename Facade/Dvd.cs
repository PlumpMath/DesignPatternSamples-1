using System;

namespace Facade
{
    public class Dvd
    {
        public void On()
        {
            Console.WriteLine("Dvd is on");
        }

        public void Off()
        {
            Console.WriteLine("Dvd is off");
        }

        public void Play()
        {
            Console.WriteLine("Dvd is playing");
        }

        public void Stop()
        {
            Console.WriteLine("Dvd is stopped");
        }
    }
}