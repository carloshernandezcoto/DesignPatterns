namespace PatternsApp.Factory.Matcha
{
    public interface IViewEngine
    {
        public string Render(string viewName, Dictionary<string, object> context);
    }
}