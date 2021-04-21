using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.VisitorPattern.Example1
{
    public class HtmlDocument
    {
        private List<IHtmlNode> nodes = new List<IHtmlNode>();

        public void Add(IHtmlNode node)
        {
            nodes.Add(node);
        }

        public void Execute(IOperation operation)
        {
            foreach(var n in nodes)
                n.Execute(operation);
        }
    }
}
