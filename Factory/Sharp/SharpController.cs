using PatternsApp.Factory.Matcha;
using PatternsApp.Factory.Sharp;

namespace PatternsApp.Factory
{
    public class SharpController : Controller
    {
        protected override IViewEngine CreateViewEngine()
        {
            return new SharpViewEngine();
        }
    }
}