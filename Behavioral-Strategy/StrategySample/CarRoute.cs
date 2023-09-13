namespace StrategySample
{
    // Concrete Strategy B
    // The following CarRoute Concrete Strategy implement the Strategy Interface and 
    // Implement the FindBestRoute Method. 
    public class CarRoute : IDirection
    {
        public void FindBestRoute()
        {
            Console.WriteLine("Returning best route for car");
        }
    }
}