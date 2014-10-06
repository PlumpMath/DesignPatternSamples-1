using System;

namespace Iterator
{
    public class MenuItem
    {
        private readonly string _name;
        private readonly string _description;
        private readonly double _price;

        public MenuItem(string name, string description, double price)
        {
            _name = name;
            _description = description;
            _price = price;
        }

        public void Display()
        {
            Console.WriteLine("{0} {1} {2}", _name, _description, _price);
        }
    }
}