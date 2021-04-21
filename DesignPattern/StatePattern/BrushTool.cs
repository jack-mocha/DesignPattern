using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.StatePattern
{
    public class BrushTool : ITool
    {
        public string MouseDown()
        {
            return "Brush";
        }

        public string MouseUp()
        {
            return "Brush something";
        }
    }
}
