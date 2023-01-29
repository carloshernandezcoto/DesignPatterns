namespace PatternsApp.Mediator
{
    public class ListBox : UIControl
    {
        private string selection;
        public bool CanModifyTextbox
        {
            get => true;
        }
        public string Selection
        {
            get => selection;
            set
            {
                selection = value;
                NotifyEventHandlers();
            }
        }
    }
}