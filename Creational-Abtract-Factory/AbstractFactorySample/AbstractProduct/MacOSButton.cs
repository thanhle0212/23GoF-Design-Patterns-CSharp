namespace AbstractFactorySample.AbstractProduct
{
    // Concrete Products are created by corresponding Concrete Factories.
    public class MacOSButton : IButton
    {
        public void Click()
        {
            Console.WriteLine("Click Event from MacOS Button");
        }
    }
}