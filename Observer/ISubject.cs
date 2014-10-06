namespace Observer
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void NotifyObservers(float temperature, float humidity);
    }
}