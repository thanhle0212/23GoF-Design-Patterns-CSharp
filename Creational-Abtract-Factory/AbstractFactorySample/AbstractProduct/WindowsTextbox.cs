namespace AbstractFactorySample.AbstractProduct
{
    public class WindowsTextBox : ITextbox
    {
        public void Input()
        {
            Console.WriteLine("Input Event from Windows Textbox");
        }
    }
}