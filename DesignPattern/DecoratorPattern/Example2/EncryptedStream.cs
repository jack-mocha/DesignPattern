using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DecoratorPattern.Example2
{
    public class EncryptedStream : BaseDecorator
    {

        public EncryptedStream(IStream stream) : base(stream)
        {
        }

        public override void Write(string data)
        {
            var encrypted = Encrypt(data);
            base.Write(encrypted);
        }

        private string Encrypt(string data)
        {
            return "@#)$(U@($DFSD(";
        }
    }
}
