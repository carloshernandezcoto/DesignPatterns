namespace PatternsApp.Mediator
{
    public class ArticlesForm
    {
        private ListBox articlesListBox;
        private TextBox titleTextBox;
        private Button saveButton;

        public ArticlesForm()
        {
            articlesListBox = new ListBox();
            titleTextBox = new TextBox();
            saveButton = new Button();
            articlesListBox.AddEventHandler(titleTextBox);
            titleTextBox.AddEventHandler(saveButton);
            // saveButton.AddEventHandler();
        }
        public void SimulateUserInteraction()
        {
            articlesListBox.Selection = "Chicken";
            Console.WriteLine("Listbox selection: {0}", articlesListBox.Selection);
            Console.WriteLine("Textbox content: {0}", titleTextBox.Content);
            Console.WriteLine("Buton enabled: {0}", saveButton.IsEnabled);
            articlesListBox.Selection = null;
            //titleTextBox.Content = "Apple"; //this is wrong, app need fix
            Console.WriteLine("Listbox selection: {0}", articlesListBox.Selection);
            Console.WriteLine("Textbox content: {0}", titleTextBox.Content);
            Console.WriteLine("Buton enabled: {0}", saveButton.IsEnabled);


        }

        // public void Handle(UIControl sender)
        // {
        //if (sender == articlesListBox) ArticleSelected();
        //else 
        //     if (sender == titleTextBox) TitleChanged();
        // }

        // private void ArticleSelected()
        // {
        //     titleTextBox.Content = articlesListBox.Selection;
        // }
        // private void TitleChanged()
        // {
        //     saveButton.IsEnabled =
        //    (titleTextBox.Content != null && titleTextBox.Content != "");
        // }
    }
}