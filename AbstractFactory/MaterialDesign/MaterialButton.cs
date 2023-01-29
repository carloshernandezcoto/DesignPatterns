namespace PatternsApp.AbstractFactory.MaterialDesign
{
    public class MaterialButton : IButton
    {
        public void Render()
        {
            System.Console.WriteLine("Material design button...");
        }
    }
}