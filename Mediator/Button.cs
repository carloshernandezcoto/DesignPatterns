namespace PatternsApp.Mediator
{
    public class Button : UIControl, IEventHandler
    {
        private bool isEnabled;
        public bool IsEnabled
        {
            get => isEnabled;
            set
            {
                isEnabled = value;
                NotifyEventHandlers();
            }
        }

        // This is wrong, specific behavior of the dialog box doesn't belong here.
        // This class is a generic button, part of a framework and it can be used in many 
        // applications. It shouldn't know anything about dialog boxes.
        public void Handle(UIControl sender)
        {
            TextBox tb = (TextBox)sender;
            IsEnabled = !(tb.Content == null || tb.Content == "");
        }
    }
}