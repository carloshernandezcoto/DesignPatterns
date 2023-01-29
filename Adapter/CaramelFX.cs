namespace PatternsApp.Adapter
{
    public class CaramelFX
    {
        // This method has to run allways before applying the image filter.
        public void Init()
        {
            System.Console.WriteLine("Running init on CaramelFx class...");
        }

        public void Render(Image image)
        {
            System.Console.WriteLine("Running render from CaramelFx class...");
        }
    }
}