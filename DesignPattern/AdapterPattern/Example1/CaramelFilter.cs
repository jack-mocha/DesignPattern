using DesignPattern.AdapterPattern.Example1.AvaFilters;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AdapterPattern.Example1
{
    public class CaramelFilter : IFilter
    {
        private Caramel _caramel;

        public CaramelFilter(Caramel caramel)
        {
            _caramel = caramel;
        }

        public void Apply(Image image)
        {
            _caramel.Init(); //Image this is the requirement to use the 3rd party library
            _caramel.Render(image);
        }
    }
}
