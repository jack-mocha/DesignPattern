using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.MediatorPattern.Example1
{
    public class ListBox : UIControl
    {
        private string _selection;
        public string Selection
        {
            get { return _selection; }
            set
            {
                _selection = value;
                _owner.Changed(this);
            }
        }

        public ListBox(DialogBox owner) : base(owner)
        {
        }
    }
}
