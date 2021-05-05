using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FlyweightPattern.Example1
{
    public class Point
    {
        private int _x;
        private int _y;
        private PointIcon _icon;

        public Point(int x, int y, PointIcon icon)
        {
            _x = x;
            _y = y;
            _icon = icon;
        }

        public string Draw()
        {
            return String.Format("{0} at ({1}, {2})", _icon.Type, _x, _y);
        }
    }
}
