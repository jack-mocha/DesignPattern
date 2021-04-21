using DesignPattern.CommandPattern.Example2;
using DesignPattern.CommandPattern.Example2.FX;
using NUnit.Framework;

namespace DesignPattern.UnitTests.Command.Example2
{
    public class CommandE2UnitTests
    {
        private string ResizeResult;
        private string BlackAndWhiteResult;

        [SetUp]
        public void Setup()
        {
            ResizeResult = "Resized.";
            BlackAndWhiteResult = "Black and White.";
        }

        [Test]
        public void Button_Clicked_AddUser()
        {
            var composite = new CompositeCommand();
            var resize = new ResizeCommand();
            var blackAndWhite = new BlackAndWhiteCommand();

            composite.Add(resize);
            composite.Add(blackAndWhite);
            var button = new Button(composite);

            button.Click();

            Assert.That(resize.Result, Is.EqualTo(ResizeResult));
            Assert.That(blackAndWhite.Result, Is.EqualTo(BlackAndWhiteResult));
        }
    }
}