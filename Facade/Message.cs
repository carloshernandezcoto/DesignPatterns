namespace PatternsApp.Facade
{
    public class Message
    {
        private string content;

        public Message(string content)
        {
            this.Content = content;
        }

        public string Content { get => content; set => content = value; }
    }
}