using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FlyweightPattern.Example1
{
    public class PointIconFactory
    {
        private Dictionary<PointType, PointIcon> icons = new Dictionary<PointType, PointIcon>();

        public PointIcon GetPointIcon(PointType type)
        {
            if (!icons.ContainsKey(type))
            {
                var icon = new PointIcon(type, null);
                icons.Add(type, icon);
            }

            return icons[type];
        }
    }
}
