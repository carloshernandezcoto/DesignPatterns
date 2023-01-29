namespace PatternsApp.AbstractFactory.MaterialDesign
{
    public class MaterialTextbox : ITextbox
    {
        public void Render()
        {
            System.Console.WriteLine("Material design textbox...");
        }
    }
}