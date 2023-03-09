using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMethodSample
{
    // Step 3 : Define the Delivery Method - Creator 
    // (we can choose either abstract class or interface)
    public abstract class DeliveryMethod
    {
        // This method must be override in concrete delivery method classes (Fast/Regular/Cheap)
        // We can also provide the default implementation of the factory method
        // i.e. The default delivery method is standard (deliver by motorbike)
        public abstract IVehicle VehicleFactory();

        // This method contains core logics. 
        // It will perform the action based on the vehicle which return by VehicleFactory method
        public string Deliver()
        {
            var vehicle = VehicleFactory();

            var result = $"The item will be delivered by {vehicle.Operation()}";

            return result;
        }
    }
}