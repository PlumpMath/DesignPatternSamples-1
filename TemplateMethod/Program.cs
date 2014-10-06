using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main()
        {
            Tea tea = new Tea();
            tea.PrepareReceipe();

            Coffee coffee = new Coffee();
            coffee.PrepareReceipe();

            Console.ReadLine();
        }
    }
}
