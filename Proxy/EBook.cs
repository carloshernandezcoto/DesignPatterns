namespace PatternsApp.Proxy
{
    public class EBook : IEBook
    {
        private string fileName;

        public string FileName { get => fileName; }

        public EBook(string fileName)
        {
            this.fileName = fileName;
            Load();
        }
        private void Load()
        {
            System.Console.WriteLine("Loading the ebook: {0}", FileName);
        }

        public void Show()
        {
            System.Console.WriteLine("Showing the ebook: {0}", FileName);
        }
    }
}