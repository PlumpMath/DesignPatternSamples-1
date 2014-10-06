using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Iterator
{
    public class BreakfastMenu : IEnumerable<MenuItem>
    {
        private readonly MenuItem[] _items;

        public BreakfastMenu()
        {
            _items = new MenuItem[3];

            _items[0] = new MenuItem("Pancakes", "Decilious pancakes", 1.99);
            _items[1] = new MenuItem("Waffles", "Yummy waffles", 2.50);
            _items[2] = new MenuItem("Toast", "Perfect toast", 2.50);
        }

        public IEnumerator<MenuItem> GetEnumerator()
        {
            return _items.AsEnumerable().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}