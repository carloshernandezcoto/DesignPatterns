namespace PatternsApp.Decorator
{
    public class CloudStream : IStream
    {
        public void Write(string data)
        {
            System.Console.WriteLine("Storing packet({0}) on the cloud.", data);
        }
    }
}