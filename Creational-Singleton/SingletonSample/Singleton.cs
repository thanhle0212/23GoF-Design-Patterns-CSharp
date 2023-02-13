namespace SingletonSample
{
    public sealed class Singleton
    {
        private static Singleton? _instance = null;
        private static readonly object _lock = new object();
        private Singleton()
        {

        }

        public static Singleton GetInstance(string value)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                    _instance.InitialValue = value;
                }
                return _instance;
            }
        }

        public void Print(string message)
        {
            Console.WriteLine(message);
        }
        public string InitialValue { get; set; }

    }
}