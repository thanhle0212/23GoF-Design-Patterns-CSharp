namespace FactoryMethodSample
{
    // Step 1: Define the Vehicle interface/abstract class 
    // The Vehicle interface declares the operations that all concrete Vehicle must implement
    public interface IVehicle
    {
        string Operation();
    }


    // Step 2: Define concreate classes which implement IVehicle interface
    // Each class will have different implementation for Operation method
    public class Ship : IVehicle
    {
        public string Operation()
        {
            return "Ship!";
        }
    }

    public class Car : IVehicle
    {
        public string Operation()
        {
            return "Car!";
        }
    }

    public class AirCraft : IVehicle
    {
        public string Operation()
        {
            return "Aircraft!";
        }
    }

    public class Train:IVehicle
    {
        public string Operation()
        {
            return "Train!";
        }
    }
}