using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.StatePattern
{
    public class SelectionTool : ITool
    {
        public string MouseDown()
        {
            return "Select";
        }

        public string MouseUp()
        {
            return "Draw a rectangle";
        }
    }
}
