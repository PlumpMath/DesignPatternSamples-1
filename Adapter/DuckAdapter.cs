namespace Adapter
{
    public class DuckAdapter : IDuck
    {
        private readonly ITurkey _turkey;

        public DuckAdapter(ITurkey turkey)
        {
            _turkey = turkey;
        }

        public void Quack()
        {
            _turkey.Gobble();
        }

        public void Fly()
        {
            _turkey.Fly();
        }
    }
}