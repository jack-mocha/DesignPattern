using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.StrategyPattern.Exercise1
{
    public class PngCompressor : ICompressor
    {
        public string Compress(string fileName)
        {
            return "Compressing using Png";
        }
    }
}
