using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.MementoPattern.Example2
{
    //This example utilizes nested class.
    public class Editor
    {
        public string Content { get; set; }

        public EditorState CreateState()
        {
            return new EditorState(this.Content);
        }

        public void RestoreState(EditorState state)
        {
            this.Content = state.Content;
        }

        public class EditorState
        {
            public string Content { get; private set; }

            public EditorState(string content)
            {
                this.Content = content;
            }
        }
    }
}
