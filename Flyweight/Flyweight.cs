namespace PatternsApp.Flyweight
{
    public class Flyweight : IPattern
    {
        public void Execute()
        {
            PrintAppMsg.Print("Starting Facade pattern execution..." + Environment.NewLine);

            var iconFactory = new PointIconFactory();
            var service = new PointService(iconFactory);
            foreach (var point in service.GetPoints()) { point.Draw(); }

            Console.ReadKey();
        }
    }
}