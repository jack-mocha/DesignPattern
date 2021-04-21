using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.VisitorPattern.Example1
{
    public class HighlightOperation : IOperation
    {
        public string Apply(HeadingNode heading)
        {
            return "Highlight heading";
        }

        public string Apply(AnchorNode anchor)
        {
            return "Highlight anchor";
        }
    }
}
