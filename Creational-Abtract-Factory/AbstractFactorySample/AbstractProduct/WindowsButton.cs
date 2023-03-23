namespace AbstractFactorySample.AbstractProduct
{
    public class WindowsButton : IButton
    {
        public void Click()
        {
            Console.WriteLine("Click Event from Windows Button");
        }
    }
}