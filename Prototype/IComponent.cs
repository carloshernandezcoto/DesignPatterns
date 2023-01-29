namespace PatternsApp.Prototype
{
    public interface IComponent
    {
        public void Render();
        public IComponent Clone();
    }
}