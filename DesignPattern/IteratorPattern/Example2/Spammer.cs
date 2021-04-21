using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.IteratorPattern.Example2
{
    public class Spammer
    {
        public List<string> Result { get; private set; }

        public Spammer()
        {
            this.Result = new List<string>();
        }

        public void Send(IProfileIterator<string> iterator, string message)
        {
            while(iterator.HasMore())
            {
                var profile = iterator.GetNext();
                Result.Add("Send message to " + profile);
            }
        }
    }
}
