namespace BridgeSample
{
    // The Abstraction defines the interface for the "control" part of the two
    // class hierarchies. It maintains a reference to an object of the
    // Implementation hierarchy and delegates all of the real work to this
    // object.
    public abstract class Message
    {
        protected ICommunication _messageSender;

        protected Message(ICommunication messageSender, string subject, string content)
        {
            _messageSender = messageSender;
            Subject = subject;
            Content = content;
        }

        public string Subject { get; set; }
        public string Content { get; set; }
        public abstract void Send();
    }
}