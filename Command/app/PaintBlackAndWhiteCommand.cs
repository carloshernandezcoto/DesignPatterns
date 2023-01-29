using PatternsApp.Command.fx;

namespace PatternsApp.Command.app
{
    public class PaintBlackAndWhiteCommand : ICommand
    {
        private string name = "Paint Black and White";
        public string Name { get => name; }
        public void Execute()
        {
            Console.WriteLine("Applying black and white filter to image...");
        }
    }
}