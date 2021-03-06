using DesignPattern.MementoPattern;
using NUnit.Framework;

namespace DesignPatterns.UnitTests
{
    public class Tests
    {
        [Test]
        public void RestoreState_WhenCalled_ReturnPrevioiusState()
        {
            var editor = new Editor();
            var history = new History();

            editor.Content = "a";
            history.Push(editor.CreateState());

            editor.Content = "b";
            history.Push(editor.CreateState());

            editor.Content = "c";
            editor.RestoreState(history.Pop());

            var result = editor.Content;
            
            Assert.That(result, Is.EqualTo("b"));
        }

        [Test]
        public void RestoreState_WhenHistoryIsEmpty_ReturnNull()
        {
            var editor = new Editor();
            var history = new History();

            editor.Content = "a";
            history.Push(editor.CreateState());

            editor.Content = "b";
            editor.RestoreState(history.Pop());
            editor.RestoreState(history.Pop());

            var result = editor.Content;

            Assert.That(result, Is.Null);
        }
    }
}