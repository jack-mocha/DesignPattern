using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AdapterPattern.Example1
{
    public class VividFilter : IFilter
    {
        public void Apply(Image image)
        {
            Console.WriteLine("Applying Vivid Filter");
        }
    }
}
