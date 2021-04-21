using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.VisitorPattern.Example1
{
    public interface IOperation
    {
        string Apply(HeadingNode heading);
        string Apply(AnchorNode anchor);
    }
}
