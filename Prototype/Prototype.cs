namespace PatternsApp.Prototype
{
    public class Prototype : IPattern
    {
        public void Execute()
        {
            PrintAppMsg.Print("Starting Prototype pattern execution..." + Environment.NewLine);

            var circle1 = new Circle(1, "Circle1");
            var contextMenu = new ContextMenu();
            contextMenu.Duplicate(circle1);

            Console.ReadKey();
        }
    }
}