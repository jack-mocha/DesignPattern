using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.IteratorPattern.Example2
{
    public interface IProfileIterator<T>
    {
        bool HasMore();
        T GetNext();
    }
}
