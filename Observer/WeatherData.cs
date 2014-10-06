using System.Collections.Generic;

namespace Observer
{
    public class WeatherData : ISubject
    {
        private readonly IList<IObserver> _observers;

        public WeatherData()
        {
            _observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void NotifyObservers(float temperature, float humidity)
        {
            foreach (var observer in _observers)
            {
                observer.Update(temperature, humidity);
            }
        }
    }
}