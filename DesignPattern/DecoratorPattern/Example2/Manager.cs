using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DecoratorPattern.Example2
{
    public class Manager
    {
        public void StoreCreditCard(IStream stream, string data)
        {
            stream.Write(data);
        }
    }
}
