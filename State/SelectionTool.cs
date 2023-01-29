namespace PatternsApp.State
{
    public class SelectionTool : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Selection icon being shown now...");
        }

        public void MouseUp()
        {
            Console.WriteLine("Dashed rectangle being drawed now...");
        }
    }
}