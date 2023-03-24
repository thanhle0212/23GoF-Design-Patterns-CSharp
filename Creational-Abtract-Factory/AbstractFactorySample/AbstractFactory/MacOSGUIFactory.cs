using AbstractFactorySample.AbstractProduct;

namespace AbstractFactorySample.AbstractFactory
{
    // Concrete Factories produce a family of products that belong to a single
    // variant. The factory guarantees that resulting products are compatible.
    // Note that signatures of the Concrete Factory's methods return an abstract
    // product, while inside the method a concrete product is instantiated.
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