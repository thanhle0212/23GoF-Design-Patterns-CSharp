using AbstractFactorySample.AbstractProduct;

namespace AbstractFactorySample.AbstractFactory
{
    public class MacOSGUIFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new MacOSButton();
        }

        public IMenu CreateMenu()
        {
            return new MacOSMenu();
        }

        public ITextbox CreateTextbox()
        {
            return new MacOSTextbox();
        }
    }
}