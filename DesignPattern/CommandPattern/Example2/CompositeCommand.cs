using DesignPattern.CommandPattern.Example2.FX;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CommandPattern.Example2
{
    public class CompositeCommand : ICommand
    {
        private List<ICommand> Commands = new List<ICommand>();

        public void Add(ICommand command)
        {
            Commands.Add(command);
        }

        public void Execute()
        {
            foreach (var c in Commands)
                c.Execute();
        }
    }
}
