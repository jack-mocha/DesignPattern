using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.MediatorPattern.Example1
{
    public class ArticlesDialogBox : DialogBox
    {
        private ListBox _articlesListBox;
        private TextBox _titleTextBox;
        private Button _saveButton;

        public void SimulateUserInteraction()
        {
            _articlesListBox.Selection = "Article 1";
            _titleTextBox.Content = "";
            _titleTextBox.Content = "Article 2";
            Console.WriteLine("TextBox: " + _titleTextBox.Content);
            Console.WriteLine("Button: " + _saveButton.IsEnabled);
        }

        public ArticlesDialogBox()
        {
            _articlesListBox = new ListBox(this);
            _titleTextBox = new TextBox(this);
            _saveButton = new Button(this);
        }

        public override void Changed(UIControl control)
        {
            if (control == _articlesListBox)
                ArticleSelected();
            else if (control == _titleTextBox)
                TitleChanged();
        }

        private void TitleChanged()
        {
            var content = _titleTextBox.Content;
            var isEmpty = String.IsNullOrWhiteSpace(content);
            _saveButton.IsEnabled = !isEmpty;
        }

        private void ArticleSelected()
        {
            _titleTextBox.Content = _articlesListBox.Selection;
            _saveButton.IsEnabled = true;
        }
    }
}
