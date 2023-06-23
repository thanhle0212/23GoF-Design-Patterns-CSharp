namespace DecoratorSample
{
    // This is the Base Component that defines operations that can be altered by decorators
    // We can also use Abstract class instead of Interface
    public interface INotifier
    {
        public void SendMessage();
    }
}