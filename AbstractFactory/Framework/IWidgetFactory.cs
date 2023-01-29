namespace PatternsApp.AbstractFactory.Framework
{
    public interface IWidgetFactory
    {
        public IButton CreateButton();
        public ITextbox CreateTextbox();
    }
}