namespace PatternsApp.Mediator
{
    public class Mediator : IPattern
    {
        public void Execute()
        {
            PrintAppMsg.Print("Starting Mediator pattern execution..." + Environment.NewLine);

            var dialog = new ArticlesForm();
            dialog.SimulateUserInteraction();

            Console.ReadKey();
        }
    }
}