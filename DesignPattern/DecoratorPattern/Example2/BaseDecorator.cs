using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DecoratorPattern.Example2
{
    public class BaseDecorator : IStream
    {
        private IStream _stream;

        public BaseDecorator(IStream stream)
        {
            this._stream = stream;
        }

        public virtual void Write(string data)
        {
            _stream.Write(data);
        }
    }
}
