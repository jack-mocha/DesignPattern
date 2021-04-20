using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ChainOfResponsibilityPattern.Example1
{
    public class Authenticator : Handler
    {
        public string Result = "IsAuthenticated: "; //Only for unit test
        public Authenticator(Handler handler) : base(handler)
        {
        }

        protected override bool DoHandle(HttpRequest request)
        {
            var isValid = request.UserName.Equals("admin") && request.Password.Equals("1234");
            Result += isValid.ToString();
            Console.WriteLine(Result);

            return isValid;
        }
    }
}
