using PatternsApp.Command.fx;
using PatternsApp.Command.app;
using PatternsApp.Command.htmlEditor;

namespace PatternsApp.Command
{
    public class Command : IPattern
    {
        public void Execute()
        {
            PrintAppMsg.Print("Starting Command pattern execution..." + Environment.NewLine);

            //Implements some button on a customer service form.
            PrintAppMsg.Print("Implementing a button on a customer service form....");
            PrintAppMsg.Print("====================================================");
            var customerService = new CustomerService();
            var command = new AddCustomerCommand(customerService);
            var button = new Button(command);
            button.Click();

            //Implements a composite command over an image.
            PrintAppMsg.Print(Environment.NewLine + "Implementing a composite command over an image....");
            PrintAppMsg.Print("====================================================");
            var imageCompositeCommand = new CompositeCommand();
            imageCompositeCommand.Add(new PaintBlackAndWhiteCommand());
            imageCompositeCommand.Add(new ResizeImageCommand());
            imageCompositeCommand.Add(new SaveImageCommand());
            imageCompositeCommand.Execute();

            //Implements a composite command over an image.
            PrintAppMsg.Print(Environment.NewLine + "Implementing an html editor with undo commands....");
            PrintAppMsg.Print("====================================================");
            var history = new History();
            var document = new HtmlDocument("This represents a DOM");
            var boldCommand = new BoldCommand(document, history);
            var foregroundCommand = new ForegroundCommand(document, history, ConsoleColor.DarkGreen);
            var backgroundCommand = new BackgroundCommand(document, history, ConsoleColor.Yellow);
            var undoCommand = new UndoCommand(history);

            document.print();
            boldCommand.Execute();
            foregroundCommand.Execute();
            backgroundCommand.Execute();
            document.print();

            undoCommand.Execute();
            undoCommand.Execute();
            document.print();
            undoCommand.Execute();
            document.print();
            foregroundCommand.NewColor = ConsoleColor.Red;
            backgroundCommand.NewColor = ConsoleColor.Gray;
            foregroundCommand.Execute();
            backgroundCommand.Execute();
            document.print();
            undoCommand.Execute();
            undoCommand.Execute();
            document.print();
            undoCommand.Execute();
            document.print();

            Console.ReadKey();
        }


    }
}