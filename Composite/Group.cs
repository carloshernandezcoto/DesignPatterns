namespace PatternsApp.Composite
{
    public class Group : IComponent
    {
        private List<IComponent> components;
        private string name;
        public string Name { get => name; set => name = value; }
        public Group(string name)
        {
            this.components = new List<IComponent>();
            this.name = name;
        }
        public void Add(IComponent component)
        {
            components.Add(component);
        }

        public void Move()
        {
            Console.WriteLine("Moving {0}...", name);
            components.ForEach(c => c.Move());
        }

        public void Render()
        {
            Console.WriteLine("Rendering {0}...", name);
            components.ForEach(c => c.Render());
        }
    }
}