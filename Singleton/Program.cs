using System;

namespace Singleton
{
    class Program
    {
        static void Main()
        {
            Singleton create1 = Singleton.CreateInstance();
            Singleton create2 = Singleton.CreateInstance();

            bool areTheSame = ReferenceEquals(create1, create2);

            Console.WriteLine(areTheSame);
            Console.ReadLine();
        }
    }
}
