using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CommandPattern.Example1.FX
{
    public class Button
    {
        private ICommand Command;

        public Button(ICommand command)
        {
            Command = command;
        }

        public void Click()
        {
            Command.Execute();
        }
    }
}
