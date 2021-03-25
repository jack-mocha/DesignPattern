using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.IteratorPattern.Example2
{
    public class CoworkerProfileIterator : IProfileIterator<string>
    {
        private IIterable<string> profiles;
        private int index;

        public CoworkerProfileIterator(IIterable<string> profiles)
        {
            this.profiles = profiles;
        }
        public string GetNext()
        {
            return this.profiles.profiles[index++];
        }

        public bool HasMore()
        {
            return index < profiles.profiles.Count;
        }
    }
}
