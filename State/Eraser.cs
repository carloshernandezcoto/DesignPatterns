namespace PatternsApp.State
{
    public class Eraser : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Eraser icon being shown now...");
        }

        public void MouseUp()
        {
            Console.WriteLine("Stuff erased from the canvas...");
        }
    }
}