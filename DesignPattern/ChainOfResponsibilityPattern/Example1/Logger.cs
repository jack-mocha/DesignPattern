using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ChainOfResponsibilityPattern.Example1
{
    public class Logger : Handler
    {
        public string Result = "IsLogged: "; //Only for unit test

        public Logger(Handler handler) : base(handler)
        {
        }

        protected override bool DoHandle(HttpRequest request)
        {
            Result += "True";
            Console.WriteLine(Result);

            return true;
        }
    }
}
