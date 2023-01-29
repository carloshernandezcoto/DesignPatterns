using PatternsApp.Command.fx;

namespace PatternsApp.Command.app
{
    public class ResizeImageCommand : ICommand
    {
        private string name = "Resize Image";
        public string Name { get => name; }
        public void Execute()
        {
            Console.WriteLine("Resizing image...");
        }
    }
}