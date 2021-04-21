using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CommandPattern.Example3
{
    public class BoldCommand : IUndoableCommand
    {
        private string PrevContent;
        private HtmlDocument Document;
        private History History;

        public BoldCommand(HtmlDocument document, History history)
        {
            this.Document = document;
            this.History = history;
        }

        public void Execute()
        {
            PrevContent = Document.Content;
            Document.MakeBold();
            History.Push(this);
        }

        public void Unexecute()
        {
            Document.Content = PrevContent;
        }
    }
}
