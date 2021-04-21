using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.StatePattern
{
    public class Canvas
    {
        public ITool CurrentTool { get; set; }
        public string Result { get; private set; } //Only for unit testing.

        public void MouseDown()
        {
            Result = this.CurrentTool.MouseDown();
        }

        public void MouseUp()
        {
            Result = this.CurrentTool.MouseUp();
        }
    }
}
