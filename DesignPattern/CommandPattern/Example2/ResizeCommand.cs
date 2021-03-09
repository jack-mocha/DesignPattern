using DesignPattern.CommandPattern.Example2.FX;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CommandPattern.Example2
{
    public class ResizeCommand : ICommand
    {
        public string Result { get; set; } //This is for unit testing only.

        public void Execute()
        {
            Result = "Resized.";
        }
    }
}
