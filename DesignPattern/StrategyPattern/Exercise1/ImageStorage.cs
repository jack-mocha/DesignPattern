using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.StrategyPattern.Exercise1
{
    public class ImageStorage
    {
        public string CompressResult { get; private set; } //Only for unit test
        public string FilterResult { get; private set; } //Only for unit test

        public void Store(string fileName, ICompressor compressor, IFilter filter)
        {
            CompressResult = compressor.Compress(fileName);
            FilterResult = filter.Apply(fileName);
        }
    }
}
