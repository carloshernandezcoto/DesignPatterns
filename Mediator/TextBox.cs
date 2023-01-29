namespace PatternsApp.Mediator
{
    public class TextBox : UIControl, IEventHandler
    {
        private string content;
        public string Content
        {
            get => content;
            private set
            {
                content = value;
                NotifyEventHandlers();
            }
        }

        // This is wrong, specific behavior of the dialog box doesn't belong here.
        // This class is a generic textbox, part of a framework and it can be used in many 
        // applications. It shouldn't know anything about dialog boxes.
        public void Handle(UIControl sender)
        {
            ListBox lb = (ListBox)sender;
            Content = lb.Selection;
        }
    }
}