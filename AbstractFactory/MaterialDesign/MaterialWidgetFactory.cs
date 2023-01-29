using PatternsApp.AbstractFactory.Framework;

namespace PatternsApp.AbstractFactory.MaterialDesign
{
    public class MaterialWidgetFactory : IWidgetFactory
    {
        public IButton CreateButton()
        {
            return new MaterialButton();
        }

        public ITextbox CreateTextbox()
        {
            return new MaterialTextbox();
        }
    }
}