using PatternsApp.Command.fx;

namespace PatternsApp.Command.app
{
    public class SaveImageCommand : ICommand
    {
        private string name = "Save Image";
        public string Name { get => name; }
        public void Execute()
        {
            Console.WriteLine("Saving temporary image...");
        }
    }
}