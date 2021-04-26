using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DecoratorPattern.Example1
{
    public class EncryptedStream : IStream
    {
        private IStream _stream;

        public EncryptedStream(IStream stream)
        {
            this._stream = stream;
        }

        public void Write(string data)
        {
            var encrypted = Encrypt(data);
            _stream.Write(encrypted);
        }

        private string Encrypt(string data)
        {
            return "@#)$(U@($DFSD(";
        }
    }
}
