using PatternsApp.Factory.Matcha;

namespace PatternsApp.Factory.Sharp
{
    public class SharpViewEngine : IViewEngine
    {
        public string Render(string viewName, Dictionary<string, object> context)
        {
            return "View rendered by Sharp.";
        }
    }
}