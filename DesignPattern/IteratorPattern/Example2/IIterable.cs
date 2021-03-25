using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.IteratorPattern.Example2
{
    public interface IIterable<T>
    {
        public List<string> profiles { get; }

        IProfileIterator<T> CreateFriendsIterator();
        IProfileIterator<T> CreateCoworkerIterator();
    }
}
