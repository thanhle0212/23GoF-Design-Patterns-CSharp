namespace AbstractFactorySample.AbstractProduct
{
    public class MacOSButton : IButton
    {
        public void Click()
        {
            Console.WriteLine("Click Event from MacOS Button");
        }
    }
}