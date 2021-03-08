using System;
using System.Collections.Generic;
using System.Text;
using static DesignPattern.MementoPattern.Example2.Editor;

namespace DesignPattern.MementoPattern.Example2
{
    public class History
    {
        private Stack<EditorState> stk = new Stack<EditorState>();

        public void Push(EditorState state)
        {
            stk.Push(state);
        }

        public EditorState Pop()
        {
            return stk.Count != 0 ? stk.Pop() : null;
        }
    }
}
