using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.MediatorPattern.Example1
{
    public class TextBox : UIControl
    {
        private string _content;
        public string Content
        {
            get { return _content; }
            set
            {
                _content = value;
                _owner.Changed(this);
            }
        }

        public TextBox(DialogBox owner) : base(owner)
        {
        }
    }
}
