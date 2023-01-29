using PatternsApp.Factory.Matcha;
namespace PatternsApp.Factory
{
    public class ProductsController : SharpController
    {
        public void ListProducts()
        {
            //Get products from a DB
            var context = new Dictionary<string, object>();
            //context.Add(products)
            Render("products.html", context);
        }
    }
}