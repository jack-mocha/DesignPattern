using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DecoratorPattern.Example1
{
    public class CompressedStream : IStream
    {
        private IStream _stream;

        public CompressedStream(IStream stream)
        {
            this._stream = stream;
        }
        public void Write(string data)
        {
            var compressed = Compress(data);
            _stream.Write(compressed);
        }

        private string Compress(string data)
        {
            return data.Substring(0, 5);
        }
    }
}
