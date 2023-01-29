namespace PatternsApp.Visitor
{
    public class HighlightOperation : IOperation
    {
        public void Apply(HeadingNode heading)
        {
            System.Console.WriteLine("Highligthing heading...");
        }
        public void Apply(AnchorNode anchor)
        {
            System.Console.WriteLine("Highligthing anchor...");
        }
    }
}