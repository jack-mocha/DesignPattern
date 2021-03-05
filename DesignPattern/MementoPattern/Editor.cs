using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.MementoPattern
{
    public class Editor
    {
        public string Content { get; set; }

        public EditorState CreateState()
        {
            return new EditorState(this.Content);
        }

        public void RestoreState(EditorState state)
        {
            this.Content = state == null ? null : state.Content;
        }

    }
}
