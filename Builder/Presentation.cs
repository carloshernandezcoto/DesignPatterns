namespace PatternsApp.Builder
{
    public class Presentation
    {
        private IList<Slide> slides = new List<Slide>();
        public void AddSlide(Slide slide)
        {
            slides.Add(slide);
        }
        public void export(IPresentationBuilder builder)
        {
            builder.AddSlide(new Slide("Copyright"));
            foreach (Slide slide in slides)
            {
                builder.AddSlide(slide);
            }
        }
    }
}
