using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ObserverPattern.Example1
{
    public class Subject
    {
        private List<IObserver> observers = new List<IObserver>();
        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers(int value)
        {
            foreach (var o in observers)
                o.Update(value);
        }

        public void NotifyObservers()
        {
            foreach (var o in observers)
                o.Update();
        }
    }
}
