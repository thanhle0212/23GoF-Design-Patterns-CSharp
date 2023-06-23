namespace DecoratorSample
{
    // The Base Decorator class is also inherited from the same interface as the other Concrete Components inherited
    // The primary responsibility of this base Decorator class is to define the wrapping interface for all concrete decorators
    // The default implementation of the wrapping code includes a field/propery for storing a wrapped component and
    // we need to initialize that field/property by using constructor.
    public abstract class Decorator : INotifier
    {
        // Create a property to store the concrete Component
        protected INotifier _notifier;

        // Initializing the property using Constructor 
        // While creating an instance of the Decorator, we need to pass the existing notifier object which we want to decorate
        public Decorator(INotifier notifier)
        {
            _notifier = notifier;
        }

        public virtual void SendMessage()
        {
            _notifier.SendMessage();
        }
    }
}