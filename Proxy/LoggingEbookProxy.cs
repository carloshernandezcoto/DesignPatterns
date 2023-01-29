namespace PatternsApp.Proxy
{
    public class LoggingEbookProxy : IEBook
    {
        private string fileName;
        private EBook ebook;
        public string FileName => fileName;
        public LoggingEbookProxy(string fileName)
        {
            this.fileName = fileName;
        }
        public void Show()
        {
            if (ebook == null)
                ebook = new EBook(fileName);
            System.Console.WriteLine("Performing logging operations...");
            ebook.Show();
        }
    }
}