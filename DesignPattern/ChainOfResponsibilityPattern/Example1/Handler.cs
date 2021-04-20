using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ChainOfResponsibilityPattern.Example1
{
    public abstract class Handler
    {
        private Handler _next;

        public Handler(Handler next)
        {
            _next = next;
        }

        public void Handle(HttpRequest request)
        {
            if (!DoHandle(request))
                return;

            if (_next != null)
                _next.Handle(request);
        }

        protected abstract bool DoHandle(HttpRequest request);
    }
}
