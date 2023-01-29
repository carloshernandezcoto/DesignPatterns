namespace PatternsApp.Strategy
{
    public class BnWFilter : IFilter
    {
        public void Filter(string fileName)
        {
            Console.WriteLine("Filtering using b&w...");
        }
    }
}