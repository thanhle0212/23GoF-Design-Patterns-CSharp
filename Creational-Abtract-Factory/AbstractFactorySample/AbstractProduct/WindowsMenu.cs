namespace AbstractFactorySample.AbstractProduct
{
    public class WindowsMenu : IMenu
    {
        public void Select()
        {
            Console.WriteLine("Select Event from Windows Menu");
        }
    }
}