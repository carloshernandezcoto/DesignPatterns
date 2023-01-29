namespace PatternsApp.Strategy
{
    public class HighContrastFilter : IFilter
    {
        public void Filter(string fileName)
        {
            Console.WriteLine("Filtering using high contrast...");
        }
    }
}