using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ChainOfResponsibilityPattern.Example1
{
    public class HttpRequest
    {
        public string UserName { get; private set; }
        public string Password { get; private set; }

        public HttpRequest(string username, string password)
        {
            UserName = username;
            Password = password;
        }
    }
}
