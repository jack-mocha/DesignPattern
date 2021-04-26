using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DecoratorPattern.Example2
{
    public class CompressedStream : BaseDecorator
    {
        public CompressedStream(IStream stream) : base(stream)
        {
        }

        public override void Write(string data)
        {
            var compressed = Compress(data);
            base.Write(compressed);
        }

        private string Compress(string data)
        {
            return data.Substring(0, 5);
        }
    }
}
