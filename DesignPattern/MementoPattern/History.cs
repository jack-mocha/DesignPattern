using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.MementoPattern
{
    public class History
    {
        private Stack<EditorState> states = new Stack<EditorState>();

        public void Push(EditorState state)
        {
            states.Push(state);
        }

        public EditorState Pop()
        {
            if (states.Count != 0)
                return states.Pop();

            return null;
        }
    }
}
