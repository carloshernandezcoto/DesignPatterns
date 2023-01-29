namespace PatternsApp.Visitor
{
    public class HtmlDocument
    {
        private List<IHtmlNode> nodes = new List<IHtmlNode>();

        public void Add(IHtmlNode node)
        {
            nodes.Add(node);
        }
        public void Execute(IOperation operation)
        {
            nodes.ForEach(n => n.Execute(operation));
        }
        // public void Highlight()
        // {
        //     var highlightOperation = new HighlightOperation();
        //     nodes.ForEach(n => highlightOperation.Apply(n));
        // }
    }
}