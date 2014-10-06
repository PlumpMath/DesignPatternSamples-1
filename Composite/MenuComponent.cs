namespace Composite
{
    public abstract class MenuComponent
    {
        protected string Name;
        
        public abstract void Add(MenuComponent menuComponent);
        public abstract void Display();
    }
}