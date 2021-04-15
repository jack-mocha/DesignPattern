using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.MediatorPattern.Example2
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
                NotifyEventHandlers();
            }
        }
    }
}
