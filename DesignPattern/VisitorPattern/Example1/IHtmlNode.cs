using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.VisitorPattern.Example1
{
    public interface IHtmlNode
    {
        void Execute(IOperation operation);
    }
}
