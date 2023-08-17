namespace MediatorSample
{
    /// <summary>
    /// A Concrete Component class
    /// </summary>
    public class HotDogStand : SnackBar
    {
        public HotDogStand(IMediator mediator) : base(mediator)
        {
        }

        public override void Notify(string message)
        {
            Console.WriteLine($"HotDog Stand gets message: {message}");
        }

        public override void Send(string message)
        {
            Console.WriteLine($"HotDog Stand sends message: {message}");
            _mediator.SendMessage(message, this);
        }
    }
}