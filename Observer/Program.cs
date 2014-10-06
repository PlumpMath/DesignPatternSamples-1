using System;

namespace Observer
{
    class Program
    {
        static void Main()
        {
            ISubject weatherData = new WeatherData();
            IObserver conditionsDisplay = new ConditionsDisplay();

            weatherData.RegisterObserver(conditionsDisplay);

            weatherData.NotifyObservers(45, 10);
            weatherData.NotifyObservers(35, 25);

            Console.ReadLine();
        }
    }
}
