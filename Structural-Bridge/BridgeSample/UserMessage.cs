namespace BridgeSample
{
    public class UserMessage : Message
    {
        private string _userComment;
        public UserMessage(ICommunication messageSender, string subject, string content, string userComment) : base(messageSender, subject, content)
        {
            _userComment = userComment;
        }

        public override void Send()
        {
            var overrideMessage = $"{Content}\nUser Comment: {_userComment}";
            base._messageSender.SendMessage(Subject, overrideMessage);
        }
    }
}