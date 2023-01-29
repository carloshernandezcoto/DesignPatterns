using PatternsApp.AbstractFactory.Framework;

namespace PatternsApp.AbstractFactory.AntDesign
{
    public class AntWidgetFactory : IWidgetFactory
    {
        public IButton CreateButton()
        {
            return new AntButton();
        }

        public ITextbox CreateTextbox()
        {
            return new AntTextbox();
        }
    }
}