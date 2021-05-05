using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FlyweightPattern.Example1
{
    public class PointIcon
    {
        public PointType Type { get; private set; }
        private readonly byte[] _icon;

        public PointIcon(PointType type, byte[] icon)
        {
            Type = type;
            _icon = icon;
        }
    }
}
