using DesignPattern.TemplatePattern.Example1;
using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var task = new TransferMoneyTask();
            task.Execute();
        }
    }
}
