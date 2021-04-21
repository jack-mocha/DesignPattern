using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CommandPattern.Example3
{
    public interface IUndoableCommand : ICommand
    {
        void Unexecute();
    }
}
