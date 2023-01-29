namespace PatternsApp.Adapter
{
    public class Adapter : IPattern
    {
        public void Execute()
        {
            PrintAppMsg.Print("Starting Adapter pattern execution..." + Environment.NewLine);

            var imageView = new ImageView(new Image());
            imageView.ApplyFilter(new VividFilter());
            imageView.ApplyFilter(new CaramelFilter(new CaramelFX()));

            Console.ReadKey();
        }
    }

}