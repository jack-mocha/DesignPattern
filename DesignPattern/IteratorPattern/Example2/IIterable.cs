using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.IteratorPattern.Example2
{
    public interface IIterable<T>
    {
        IProfileIterator<T> CreateFriendsIterator();
        IProfileIterator<T> CreaateCoworkerIterator();
    }
}
