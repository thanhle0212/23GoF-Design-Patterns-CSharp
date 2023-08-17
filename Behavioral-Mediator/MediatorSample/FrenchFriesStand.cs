namespace MediatorSample
{
    public class FrenchFriesStand : SnackBar
    {
        public FrenchFriesStand(IMediator mediator) : base(mediator)
        {
        }

        public override void Notify(string message)
        {
            Console.WriteLine($"French Fries Stand gets message: {message}");
        }

        public override void Send(string message)
        {
            Console.WriteLine($"French Fries Stand sends message: {message}");
            _mediator.SendMessage(message, this);
        }
    }
}