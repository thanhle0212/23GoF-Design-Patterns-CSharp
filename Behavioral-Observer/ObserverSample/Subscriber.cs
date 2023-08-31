using System.Runtime.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObserverSample
{
    public class Subscriber : ISubscriber
    {

         //The following Property is going to hold the Subscriber's name
        public string UserName { get; set; }
        //Creating the Subscriber
        public Subscriber(string userName)
        {
            UserName = userName;
        }

        public void Update()
        {
            Console.WriteLine($"Hello {UserName}, Product is now available in the Apple Store");
        }
    }
}