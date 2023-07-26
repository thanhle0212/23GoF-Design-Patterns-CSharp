namespace CoRSample
{
    public class GadgetPurchase
    {
        public string RequestType { get; set; }
        public double ProposedAmount { get; set; }

        public GadgetPurchase(string requestType, double proposedAmount)
        {
            RequestType = requestType;
            ProposedAmount = proposedAmount;

            Console.WriteLine($"Purchase request for {RequestType} for ${ProposedAmount} has been submitted");
        }
    }
}