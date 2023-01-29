namespace PatternsApp.Composite
{
    public class Shape : IComponent
    {
        private string name;
        public string Name { get => name; set => name = value; }
        public Shape(string name)
        {
            this.name = name;
        }
        public void Move()
        {
            Console.WriteLine("Moving {0}...", name);
        }
        public void Render()
        {
            Console.WriteLine("Rendering {0}...", name);
        }
    }
}