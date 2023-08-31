namespace ObserverSample
{
    // The Publisher has states and notifies all subscribers when the state changes.
    public class Publisher
    {
        private List<ISubscriber> subscribers = new List<ISubscriber>();

        //The following properties are going to store the Product Information
        private string ProductName { get; set; }
        private int ProductPrice { get; set; }
        private string Availability { get; set; }

        // Initializing the Product information using the constructor
        public Publisher(string productName, int productPrice, string availability)
        {
            ProductName = productName;
            ProductPrice = productPrice;
            Availability = availability;
        }

        //The following Method is going to set the State of the Product
        public void SetAvailability()
        {
            Console.WriteLine("Availability changed from Out of Stock to Available.");
            NotifySubscribers();
        }

        // The following Method will be sent notifications to all Subscribers
        public void NotifySubscribers()
        {
            Console.WriteLine("Product Name :"
                            + ProductName + ", product Price : "
                            + ProductPrice + " is Now available. So, notifying all Registered users ");
            Console.WriteLine();
            foreach (ISubscriber subscriber in subscribers)
            {
                //By Calling the Update method, we are sending notifications to Subscriber
                subscriber.Update();
            }
        }
           // The subscriber will register with the Product using the following method
        public void RegisterSubscriber(ISubscriber subscriber)
        {
            Console.WriteLine($"Subscriber Added : {((Subscriber)subscriber).UserName}");
            subscribers.Add(subscriber);
        }
        
        // The subscriber will unregister from the Product using the following method
        public void RemoveSubscriber(ISubscriber subscriber)
        {
            Console.WriteLine($"Subscriber Removed : {((Subscriber)subscriber).UserName}");
            subscribers.Remove(subscriber);
        }
       
    }
}