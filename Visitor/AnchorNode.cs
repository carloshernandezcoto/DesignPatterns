namespace PatternsApp.Visitor
{
    public class AnchorNode : IHtmlNode
    {
        public void Execute(IOperation operation)
        {
            operation.Apply(this);
        }

        // public void Highlight()
        // {
        //     System.Console.WriteLine("Highligthing anchor...");
        // }
    }
}