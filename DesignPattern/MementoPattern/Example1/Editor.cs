using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.MementoPattern.Example1
{
    public class Editor
    {
        public string Content { get; set; }

        public EditorState CreateState()
        {
            return new EditorState(Content);
        }

        public void RestoreState(EditorState state)
        {
            Content = state == null ? null : state.Content;
        }

    }
}
