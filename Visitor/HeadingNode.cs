namespace PatternsApp.Visitor
{
    public class HeadingNode : IHtmlNode
    {
        public void Execute(IOperation operation)
        {
            operation.Apply(this);
        }

        // public void Highlight()
        // {
        //     System.Console.WriteLine("Highligthing heading...");
        // }
    }
}