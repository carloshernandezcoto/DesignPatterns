namespace PatternsApp.Decorator
{
    public class Decorator : IPattern
    {
        public void Execute()
        {
            PrintAppMsg.Print("Starting Decorator pattern execution..." + Environment.NewLine);

            var stream = new EncryptedCloudStream(
                               new CompressedCloudStream(
                                   new CloudStream()));
            var creditCardNumber = "1234-5678-9123-0987";
            StoreCreditCard(stream, creditCardNumber);

            Console.ReadKey();
        }

        public void StoreCreditCard(IStream stream, string cardNumber)
        {
            stream.Write(cardNumber);
        }
    }
}