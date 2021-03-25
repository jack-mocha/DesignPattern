using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.IteratorPattern.Example1
{
    public interface IIterator<T>
    {
        bool HasNext();
        T Current(); 
        void Next();
    }
}
