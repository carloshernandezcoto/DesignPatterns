using PatternsApp.AbstractFactory.Framework;

namespace PatternsApp.AbstractFactory.App
{
    public class ContactForm
    {
        public void Render(IWidgetFactory factory)
        {
            factory.CreateTextbox().Render();
            factory.CreateButton().Render();
        }
    }
}