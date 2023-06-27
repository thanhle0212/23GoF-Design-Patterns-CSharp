namespace FacadeSample
{
    // The Subsystem can accept requests either from the facade or from the client directly. 
    // In this case, from the Subsystem, the Facade is also a client
    // Facade is not a part of the Subsystem.
    public class Product
    {
        public void GetProductDetails()
        {
            Console.WriteLine("Fetching the Product Details");
        }
    }
}