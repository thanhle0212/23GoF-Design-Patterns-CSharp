namespace SingletonSample
{
    // In Singleton class, we define a method "GetInstance" which returns the singleton class. 
    // It's an alternative to constructor. It helps other objects always access the same instance of singleton class

    // NOTE: You don't need to define Singleton class as a sealed class but you should do that due to the following reason
    // We might think that defining private constructor would help us to prevent deriving this class
    // But it couldn't prevent creating "nested" class. 
    // By creating a nested class we can also execute "private" constructor twice, as a result it violates Singleton principle 
    public sealed class Singleton
    {
        // We use this static field to store the instance of Singleton class. 
        private static Singleton? _instance = null;

        // This field will be used to synchronize threads during first access to the singleton class
        private static readonly object _lock = new object();
        public string InitialValue { get; set; }

        // The singleton's constructor is "private"  to prevent directly calling with "new" operator
        private Singleton()
        {

        }

        // This is the static method that controls the access to the singleton
        // instance. On the first run, it creates a singleton object and places
        // it into the static field. On subsequent runs, it returns the client
        // existing object stored in the static field.
        public static Singleton GetInstance(string value)
        {
            // Using locks we can synchronize the method. 
            // So that only one thread can access it at any given point of time.
            lock(_lock)
            {
                // Check if the Singleton field is already initialized, the thread won't create a new object.
                if (_instance == null)
                {
                    _instance = new Singleton();
                    _instance.InitialValue = value;
                }
                return _instance;
            }
        }

        // Some random logic
        public void Print(string message)
        {
            Console.WriteLine(message);
        }

    }
}