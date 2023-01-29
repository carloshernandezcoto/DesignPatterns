using PatternsApp.AbstractFactory.App;
using PatternsApp.AbstractFactory.MaterialDesign;
using PatternsApp.AbstractFactory.AntDesign;

namespace PatternsApp.AbstractFactory
{
    public class AbstractFactory : IPattern
    {
        public void Execute()
        {
            PrintAppMsg.Print("Starting Abstract Factory pattern execution..." + Environment.NewLine);

            var form = new ContactForm();
            form.Render(new AntWidgetFactory());

            Console.ReadKey();
        }
    }
}
