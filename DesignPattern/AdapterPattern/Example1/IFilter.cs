using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AdapterPattern.Example1
{
    public interface IFilter
    {
        void Apply(Image image);
    }
}
