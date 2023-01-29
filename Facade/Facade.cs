namespace PatternsApp.Facade
{
    public class Facade : IPattern
    {
        public void Execute()
        {
            PrintAppMsg.Print("Starting Facade pattern execution..." + Environment.NewLine);

            var ns = new NotificationService();
            ns.Send("This is a message to be sent...", "TargetIP");

            Console.ReadKey();

        }
    }
}