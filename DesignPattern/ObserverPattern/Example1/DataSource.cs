using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ObserverPattern.Example1
{
    public class DataSource : Subject
    {
        private int _value; //This is called a backing field. You need this to implement the auto getter/setter.

        public int Value
        {
            get { return _value; }
            set {
                _value = value;
                NotifyObservers(_value); //Push Style
            }
        }

        private int Value2;
        public int GetValue2()
        {
            return Value2;
        }

        public void SetValue2(int value)
        {
            this.Value2 = value;
            NotifyObservers(); //Pull Style
        }
    }
}
