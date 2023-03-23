using AbstractFactorySample.AbstractFactory;

namespace AbstractFactorySample
{
    public class Client
    {
        public void Main()
        {
            // Generate Windows UI Controls
            GenerateUI(new WindowsGUIFactory());
            Console.WriteLine("===========================");
            // Generate Windows UI Controls
            GenerateUI(new MacOSGUIFactory());
        }


        public void GenerateUI(IGUIFactory factory)
        {
            var textbox = factory.CreateTextbox();
            var button = factory.CreateButton();
            var menu = factory.CreateMenu();

            textbox.Input();
            button.Click();
            menu.Select();
        }
    }
}