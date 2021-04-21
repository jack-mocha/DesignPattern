using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ChainOfResponsibilityPattern.Example1
{
    public class Compressor : Handler
    {
        public string Result = "IsCompressed: "; //Only for unit test
        public Compressor(Handler handler) : base(handler)
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
