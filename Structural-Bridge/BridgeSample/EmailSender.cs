namespace BridgeSample
{
    // Each Concrete Implementation corresponds to a specific platform and
    // implements the Implementation interface
    public class EmailSender : ICommunication
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine($"Email\n{subject}\n{body}\n");
        }
    }
}