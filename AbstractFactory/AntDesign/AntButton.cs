namespace PatternsApp.AbstractFactory.AntDesign
{
    public class AntButton : IButton
    {
        public void Render()
        {
            System.Console.WriteLine("Ant design button...");
        }
    }
}