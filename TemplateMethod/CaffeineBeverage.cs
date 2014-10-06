using System;

namespace TemplateMethod
{
    public abstract class CaffeineBeverage
    {
        public void PrepareReceipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        protected void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        protected abstract void Brew();

        protected void PourInCup()
        {
            Console.WriteLine("Pouring in cup");
        }

        protected abstract void AddCondiments();
    }
}