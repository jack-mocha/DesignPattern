using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ObserverPattern.Example1
{
    public interface IObserver
    {
        void Update(); //Pull Style
        void Update(int value); //Push Style
    }
}
