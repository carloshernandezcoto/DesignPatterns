namespace PatternsApp.Command.htmlEditor
{
    public class HtmlDocument
    {
        private string content;
        private ConsoleColor backgroundColor;
        private ConsoleColor foreGroundColor;

        public HtmlDocument(string content)
        {
            this.content = content;
            this.backgroundColor = Console.BackgroundColor;
            this.foreGroundColor = Console.ForegroundColor;
        }

        public string Content { get => content; set => content = value; }
        public ConsoleColor BackgroundColor { get => backgroundColor; set => backgroundColor = value; }
        public ConsoleColor ForeGroundColor { get => foreGroundColor; set => foreGroundColor = value; }

        public void makeBold()
        {
            content = "<b>" + content + "</b>";
        }

        public void makeItalic()
        {
            content = "<i>" + content + "</i>";
        }

        public void SetForegroundColor(ConsoleColor color)
        {
            ForeGroundColor = color;
        }

        public void SetBackgroundColor(ConsoleColor color)
        {
            BackgroundColor = color;
        }

        public void print()
        {
            Console.ForegroundColor = ForeGroundColor;
            Console.BackgroundColor = BackgroundColor;
            Console.WriteLine(content);
        }
    }
}