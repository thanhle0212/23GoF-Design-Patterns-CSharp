namespace CoRSample
{
    public class CTO : BaseApprover
    {
        public override void Process(Product request)
        {
            if (request.ProposedAmount < 3000)
            {
                Console.WriteLine($"{this.GetType().Name} approved: " +
                    $"{request.RequestType}");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.Process(request);
            }
        }
    }
}