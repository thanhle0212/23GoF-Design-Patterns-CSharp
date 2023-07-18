namespace ProxySample
{
    // The RealSubject contains some core business logic.
    // Usually, RealSubjects are capable of doing some useful work which my be very
    // slow or sensitive
    // A Proxy can solve these issues without any changes to the RealSubject
    public class SharedFolder : ISharedFolder
    {
        public void PerformRWOperation()
        {
            Console.WriteLine("Performing Read Write operation on the Shared Folder");
        }
    }
}