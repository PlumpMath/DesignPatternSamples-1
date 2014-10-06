namespace Facade
{
    public class HomeTheatreFacade
    {
        private readonly Tv _tv;
        private readonly Dvd _dvd;

        public HomeTheatreFacade(Tv tv, Dvd dvd)
        {
            _tv = tv;
            _dvd = dvd;
        }

        public void WatchMovie()
        {
            _tv.On();
            _dvd.On();
            _dvd.Play();
        }

        public void EndMovie()
        {
            _dvd.Stop();
            _dvd.Off();
            _tv.Off();
        }
    }
}