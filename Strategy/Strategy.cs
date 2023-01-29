namespace PatternsApp.Strategy
{
    public class Strategy : IPattern
    {
        public void Execute()
        {
            PrintAppMsg.Print("Starting Strategy pattern execution..." + Environment.NewLine);

            var imageStorage = new ImageStorage();
            imageStorage.Store("In some path...", new PngCompressor(), new HighContrastFilter());

            Console.ReadKey();
        }
    }
}