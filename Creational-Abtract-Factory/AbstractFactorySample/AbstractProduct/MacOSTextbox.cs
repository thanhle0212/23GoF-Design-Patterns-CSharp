namespace AbstractFactorySample.AbstractProduct
{
    public class MacOSTextbox : ITextbox
    {
        public void Input()
        {
            Console.WriteLine("Input Event from MacOS Textbox");
        }
    }
}