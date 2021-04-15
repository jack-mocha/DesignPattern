using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.MediatorPattern.Example2
{
    public class Button : UIControl
    {
        private bool _isEnabled;
        public bool IsEnabled
        {
            get { return _isEnabled;  }
            set
            {
                _isEnabled = value;
                NotifyEventHandlers();
            }
        }
    }
}
