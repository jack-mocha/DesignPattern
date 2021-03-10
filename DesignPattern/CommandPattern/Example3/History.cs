using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CommandPattern.Example3
{
    public class History
    {
        private Stack<IUndoableCommand> Commands = new Stack<IUndoableCommand>();

        public void Push(IUndoableCommand command)
        {
            Commands.Push(command);
        }

        public IUndoableCommand Pop()
        {
            return Commands.Count == 0 ? null : Commands.Pop();
        }

        public int Size()
        {
            return Commands.Count;
        }
    }
}
