using DesignPattern.AdapterPattern.Example1.AvaFilters;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AdapterPattern.Example1
{
    public class CaramelAdapter : Caramel, IFilter
    {
        public void Apply(Image image)
        {
            Init();
            Render(image);
        }
    }
}
