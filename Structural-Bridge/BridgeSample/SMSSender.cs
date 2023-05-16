namespace BridgeSample
{
    public class SMSSender : ICommunication
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine($"SMS\n{subject}\n{body}\n");
        }
    }
}