namespace PatternsApp.Visitor
{
    public class PlainTextOperation : IOperation
    {
        public void Apply(HeadingNode heading)
        {
            System.Console.WriteLine("Extracting plain text from heading...");
        }

        public void Apply(AnchorNode anchor)
        {
            System.Console.WriteLine("Extracting plain text from anchor...");
        }
    }
}