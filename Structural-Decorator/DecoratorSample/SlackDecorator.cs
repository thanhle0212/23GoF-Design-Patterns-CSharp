namespace DecoratorSample
{
    // The following Concrete Decorator class will add Slack method to the Notification
    public class SlackDecorator : Decorator
    {
        public SlackDecorator(INotifier notifier) : base(notifier)
        {
        }

        // OVerriding the SendMessage method to add logic to send message from Slack
        public override void SendMessage()
        {
            // First call to keep the existing logic for sending message via email (inherited from base)
            base.SendMessage();

            // Second call to send message from Slack
            Console.WriteLine("Sending message from Slack");

        }
    }
}