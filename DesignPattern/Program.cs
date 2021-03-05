using DesignPattern.MementoPattern;
using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var editor = new Editor();
            var history = new History();

            editor.Content = "a";
            history.Push(editor.CreateState());

            editor.Content = "b";
            history.Push(editor.CreateState());

            editor.Content = "c";
            editor.RestoreState(history.Pop());
            //editor.RestoreState(history.Pop());
            //editor.RestoreState(history.Pop());
            Console.WriteLine(editor.Content);
        }
    }
}
