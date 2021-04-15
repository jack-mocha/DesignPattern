using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.MediatorPattern.Example1
{
    public class UIControl
    {
        protected DialogBox _owner;

        public UIControl(DialogBox owner)
        {
            _owner = owner;
        }
    }
}
