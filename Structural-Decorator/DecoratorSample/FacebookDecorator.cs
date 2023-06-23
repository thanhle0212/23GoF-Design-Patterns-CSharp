namespace DecoratorSample
{
    public class FacebookDecorator : Decorator
    {
        public FacebookDecorator(INotifier notifier) : base(notifier)
        {
        }

        public override void SendMessage()
        {
            base.SendMessage();

            Console.WriteLine("Sending message from Facebook!");
        }
    }
}