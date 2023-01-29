namespace PatternsApp.Visitor
{
    public class Visitor : IPattern
    {
        public void Execute()
        {
            PrintAppMsg.Print("Starting Visitor pattern execution..." + Environment.NewLine);
            var document = new HtmlDocument();
            document.Add(new HeadingNode());
            document.Add(new AnchorNode());
            document.Execute(new HighlightOperation());
            document.Execute(new PlainTextOperation());

            Console.ReadKey();
        }
    }
}