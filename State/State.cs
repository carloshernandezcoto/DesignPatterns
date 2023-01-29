namespace PatternsApp.State
{
    public class State : IPattern
    {
        public void Execute()
        {
            PrintAppMsg.Print("Starting State pattern execution..." + Environment.NewLine);

            var canvas = new Canvas();
            //canvas.Tool = new SelectionTool();
            //canvas.Tool = new BrushTool();//
            canvas.CurrentTool = new Eraser();
            canvas.MouseDown();
            canvas.MouseUp();
            Console.ReadKey();
        }
    }
}