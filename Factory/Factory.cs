namespace PatternsApp.Factory
{
    public class Factory : IPattern
    {
        public void Execute()
        {
            PrintAppMsg.Print("Starting Factory pattern execution..." + Environment.NewLine);

            new ProductsController().ListProducts();

            Console.ReadKey();
        }
    }
}