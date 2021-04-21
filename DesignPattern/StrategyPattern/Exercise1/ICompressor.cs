using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.StrategyPattern.Exercise1
{
    public interface ICompressor
    {
        string Compress(string fileName);
    }
}
