using System;

namespace Observer
{
    public class ConditionsDisplay : IObserver
    {
        public void Update(float temperature, float humidity)
        {
            Console.WriteLine("Current conditions: {0}F degrees and {1}% humidity", temperature, humidity);
        }
    }
}