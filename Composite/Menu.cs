using System;
using System.Collections.Generic;

namespace Composite
{
    public class Menu : MenuComponent
    {
        private readonly IList<MenuComponent> _menuComponents;

        public Menu(string name)
        {
            Name = name;

            _menuComponents = new List<MenuComponent>();
        }

        public override void Add(MenuComponent menuComponent)
        {
            _menuComponents.Add(menuComponent);
        }

        public override void Display()
        {
            Console.WriteLine(Name);

            foreach (MenuComponent menuComponent in _menuComponents)
            {
                menuComponent.Display();
            }
        }
    }
}