using System;

namespace Facade
{
    class Program
    {
        static void Main()
        {
            Tv tv = new Tv();
            Dvd dvd = new Dvd();

            HomeTheatreFacade homeTheatre = new HomeTheatreFacade(tv, dvd);

            homeTheatre.WatchMovie();
            homeTheatre.EndMovie();

            Console.ReadLine();
        }
    }
}
