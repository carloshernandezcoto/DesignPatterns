namespace PatternsApp.Builder
{
    public class MovideBuilder : IPresentationBuilder
    {
        private Movie movie = new Movie();

        public Movie Movie { get => movie; }

        public void AddSlide(Slide slide)
        {
            Movie.AddFrame(slide.Text, 2);
        }
    }
}