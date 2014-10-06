using System;

namespace Composite
{
    public class MenuItem : MenuComponent
    {
        protected string Description;
        protected double Price;

        public MenuItem(string name, string description, double price)
        {
            Name = name;
            Description = description;
            Price = price;
        }

        public override void Add(MenuComponent menuComponent)
        {
            throw new NotImplementedException();
        }

        public override void Display()
        {
            Console.WriteLine("-- {0} {1} {2}", Name, Description, Price);
        }
    }
}