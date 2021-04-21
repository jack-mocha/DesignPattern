using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.StrategyPattern.Exercise1
{
    public class JpegCompressor : ICompressor
    {
        public string Compress(string fileName)
        {
            return "Compressing using Jpeg";
        }
    }
}
