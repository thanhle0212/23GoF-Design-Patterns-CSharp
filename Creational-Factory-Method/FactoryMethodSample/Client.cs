using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMethodSample
{
    public class Client
    {
        // We can pass any delivery method here, 
        // the Factory Method will call the vehicle accordingly
        public void Deliver(DeliveryMethod deliveryMethod)
        {
            Console.WriteLine(deliveryMethod.Deliver());
        }
    }
}