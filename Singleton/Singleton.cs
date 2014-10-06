namespace Singleton
{
    public class Singleton
    {
        private static Singleton _uniqueInstance;

        private Singleton()
        {
        }

        public static Singleton CreateInstance()
        {
            if (_uniqueInstance == null)
            {
                _uniqueInstance = new Singleton();
            }

            return _uniqueInstance;
        }
    }
}