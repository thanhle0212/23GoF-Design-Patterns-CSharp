namespace FactoryMethodSample
{
    // Step 4: Define the concrete creator classes (shipping type Cheap/Regular/Fast) 
    public class CheapShipping : DeliveryMethod
    {
        // This method the approtiate vehicle to deliver 
        // based on the deliver method calling from Client
        public override IVehicle VehicleFactory()
        {
            return new Ship();
        }
    }
}