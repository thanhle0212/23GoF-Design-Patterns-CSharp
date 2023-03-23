namespace AbstractFactorySample.AbstractProduct
{
    public class MacOSMenu : IMenu
    {
        public void Select()
        {
            Console.WriteLine("Select Event from MacOS Menu");
        }
    }
}
