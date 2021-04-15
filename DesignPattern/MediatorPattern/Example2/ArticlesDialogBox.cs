using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.MediatorPattern.Example2
{
    public class ArticlesDialogBox 
    {
        private ListBox _articlesListBox = new ListBox();
        private TextBox _titleTextBox = new TextBox();
        private Button _saveButton = new Button();

        public ArticlesDialogBox()
        {
            _articlesListBox.AddEventHandler(new ArticleListBoxObserver(this));
            _articlesListBox.AddEventHandler(new TitleTextBoxObserver(this));
        }

        public void SimulateUserInteraction()
        {
            _articlesListBox.Selection = "Article 1";
            _titleTextBox.Content = "";
            _titleTextBox.Content = "Article 2";
            Console.WriteLine("TextBox: " + _titleTextBox.Content);
            Console.WriteLine("Button: " + _saveButton.IsEnabled);
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

        private class ArticleListBoxObserver : IEventHandler
        {
            private ArticlesDialogBox _dialogBox;
            public ArticleListBoxObserver(ArticlesDialogBox dialogBox)
            {
                this._dialogBox = dialogBox;
            }
            public void Handle()
            {
                this._dialogBox.ArticleSelected();
            }
        }

        private class TitleTextBoxObserver : IEventHandler
        {
            private ArticlesDialogBox _dialogBox;
            public TitleTextBoxObserver(ArticlesDialogBox dialogBox)
            {
                this._dialogBox = dialogBox;
            }
            public void Handle()
            {
                this._dialogBox.TitleChanged();
            }
        }

    }
}
