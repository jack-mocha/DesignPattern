using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.StrategyPattern.Exercise1
{
    public class BlackAndWhiteFilter : IFilter
    {
        public string Apply(string fileName)
        {
            return "Applying black and white filter";
        }
    }
}
