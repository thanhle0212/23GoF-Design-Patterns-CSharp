namespace BridgeSample
{
    
    /// <sumary>
    /// The 'Bidge/Implementation" interface
    /// Implementation interface provides only primitive operations, while the Abstraction
    /// defines higher- level operations based on those primitives.
    /// </summary>
    public interface ICommunication
    {
        void SendMessage(string subject, string body);
    }
}