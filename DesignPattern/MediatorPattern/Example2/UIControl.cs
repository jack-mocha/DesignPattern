using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.MediatorPattern.Example2
{
    public abstract class UIControl
    {
        private List<IEventHandler> eventHandlers = new List<IEventHandler>();

        public void AddEventHandler(IEventHandler observer)
        {
            eventHandlers.Add(observer);
        }

        protected void NotifyEventHandlers()
        {
            foreach (var o in eventHandlers)
                o.Handle();
        }
    }
}
