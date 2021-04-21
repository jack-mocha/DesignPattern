using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CommandPattern.Example3
{
    public class UndoCommand : ICommand
    {
        private History History;

        public UndoCommand(History history)
        {
            this.History = history;
        }

        public void Execute()
        {
            if (History.Size() > 0)
                History.Pop().Unexecute();
        }
    }
}
