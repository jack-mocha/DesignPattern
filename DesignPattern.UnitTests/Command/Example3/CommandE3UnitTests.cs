using DesignPattern.CommandPattern.Example2;
using DesignPattern.CommandPattern.Example2.FX;
using DesignPattern.CommandPattern.Example3;
using NUnit.Framework;

namespace DesignPattern.UnitTests.Command.Example3
{
    public class CommandE3UnitTests
    {
        private string Content;
        private string BoldResult;

        [SetUp]
        public void Setup()
        {
            Content = "Hellow World";
            BoldResult = "<b>Hellow World</b>";
        }

        [Test]
        public void BoldCommand_WhenExecute_BoldDocumentContent()
        {
            var history = new History();
            var document = new HtmlDocument();
            document.Content = Content;

            var boldCommand = new BoldCommand(document, history);
            boldCommand.Execute();

            Assert.That(document.Content, Is.EqualTo(BoldResult));
        }

        [Test]
        public void BoldCommand_WhenUnExecute_UnBoldDocumentContent()
        {
            var history = new History();
            var document = new HtmlDocument();
            document.Content = Content;

            var boldCommand = new BoldCommand(document, history);
            boldCommand.Execute();
            Assert.That(document.Content, Is.EqualTo(BoldResult));

            var undoCommand = new UndoCommand(history);
            undoCommand.Execute();

            Assert.That(document.Content, Is.EqualTo(Content));
        }
    }
}
