using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AdapterPattern.Example1.AvaFilters
{
    public class Caramel
    {
        public string Result { get; set; } //Only for unit tests
        public void Init()
        {

        }

        public void Render(Image image)
        {
            Result = "Applying Caramel Filter";
        }
    }
}
