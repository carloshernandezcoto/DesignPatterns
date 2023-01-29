namespace PatternsApp.Adapter
{
    public class VividFilter : IFilter
    {
        public void Apply(Image image)
        {
            Console.WriteLine("Applying vivid filter on image...");
        }
    }
}