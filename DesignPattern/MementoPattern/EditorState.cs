using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.MementoPattern
{
    public class EditorState
    {
        public string Content { get; private set; }

        public EditorState(string content)
        {
            this.Content = content;
        }
    }
}
