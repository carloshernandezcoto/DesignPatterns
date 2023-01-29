namespace PatternsApp.Prototype
{
    public class ContextMenu
    {
        public void Duplicate(IComponent component)
        {
            IComponent clonedComponent = component.Clone();
            clonedComponent.Render();
        }
    }
}