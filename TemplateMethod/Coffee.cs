using System;

namespace TemplateMethod
{
    public class Coffee : CaffeineBeverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Dripping coffee through filter");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding milk and sugar");
        }
    }
}