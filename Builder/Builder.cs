namespace PatternsApp.Builder
{
    public class Builder : IPattern
    {
        public void Execute()
        {
            PrintAppMsg.Print("Starting Builder pattern execution..." + Environment.NewLine);

            var presentation = new Presentation();
            presentation.AddSlide(new Slide("Slide 1"));
            presentation.AddSlide(new Slide("Slide 2"));

            var builder = new MovideBuilder();
            presentation.export(builder);
            var movie = builder.Movie;
            Console.ReadKey();
        }
    }
}