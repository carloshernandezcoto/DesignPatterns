namespace PatternsApp.Composite
{
    public interface IComponent
    {
        public string Name { get; set; }
        public void Render();
        public void Move();
    }
}