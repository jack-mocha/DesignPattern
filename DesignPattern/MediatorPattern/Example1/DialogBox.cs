using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.MediatorPattern.Example1
{
    //Mediator
    public abstract class DialogBox
    {
        public abstract void Changed(UIControl control);
    }
}
