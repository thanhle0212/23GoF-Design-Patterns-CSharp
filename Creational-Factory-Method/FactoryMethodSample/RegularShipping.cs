namespace FactoryMethodSample
{
    public class RegularShipping : DeliveryMethod
    {
        public override IVehicle VehicleFactory()
        {
            return new Car();
        }
    }
}