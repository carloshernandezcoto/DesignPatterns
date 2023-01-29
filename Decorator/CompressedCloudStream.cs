namespace PatternsApp.Decorator
{
    public class CompressedCloudStream : IStream
    {
        private IStream stream;

        public CompressedCloudStream(IStream stream)
        {
            this.stream = stream;
        }

        public new void Write(string data)
        {
            var compressed = Compress(data);
            stream.Write(compressed);
        }
        public string Compress(string data)
        {
            return data.Substring(0, 5);
        }
    }
}