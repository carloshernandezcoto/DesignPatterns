namespace PatternsApp.Proxy
{
    public class EBookProxy : IEBook
    {
        private string fileName;
        private EBook ebook;
        public string FileName { get => fileName; }
        public EBookProxy(string fileName)
        {
            this.fileName = fileName;
        }

        public void Show()
        {
            if (ebook == null)
                ebook = new EBook(fileName);
            ebook.Show();
        }
    }
}