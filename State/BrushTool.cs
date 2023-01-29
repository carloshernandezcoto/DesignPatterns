namespace PatternsApp.State
{
    public class BrushTool : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Brush icon being shown now...");
        }

        public void MouseUp()
        {
            Console.WriteLine("Brushed line being drawed now...");
        }
    }
}
