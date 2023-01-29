namespace PatternsApp.Builder
{
    public class PdfDocumentBuilder : IPresentationBuilder
    {
        private PdfDocument document = new PdfDocument();

        public PdfDocument Document { get => document; }

        public void AddSlide(Slide slide)
        {
            Document.AddPage(slide.Text);
        }
    }
}