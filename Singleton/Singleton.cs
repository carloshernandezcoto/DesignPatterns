namespace PatternsApp.Singleton
{
    public class Singleton : IPattern
    {
        public void Execute()
        {
            PrintAppMsg.Print("Starting Singleton pattern execution..." + Environment.NewLine);

            var manager = ConfigManager.Instance;
            manager.Set("Name", "Mosh");

            var anotherManager = ConfigManager.Instance;
            System.Console.WriteLine(manager.Get("Name"));

            Console.ReadKey();
        }
    }
}