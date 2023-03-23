using AbstractFactorySample.AbstractProduct;

namespace AbstractFactorySample.AbstractFactory
{
    // Each Concrete Factory has a corresponding product variant.
    public class WindowsGUIFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public IMenu CreateMenu()
        {
            return new WindowsMenu();
        }

        public ITextbox CreateTextbox()
        {
            return new WindowsTextBox();
        }
    }
}