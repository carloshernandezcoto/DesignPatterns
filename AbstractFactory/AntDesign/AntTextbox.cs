namespace PatternsApp.AbstractFactory.AntDesign
{
    public class AntTextbox : ITextbox
    {
        public void Render()
        {
            System.Console.WriteLine("Ant textbox...");
        }
    }
}