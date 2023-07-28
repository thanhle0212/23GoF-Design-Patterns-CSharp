namespace CoRSample
{
    public class TechManager : BaseApprover
    {
        public override void Process(Product request)
        {
            if (request.ProposedAmount < 1500)
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