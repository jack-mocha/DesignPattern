using DesignPattern.StatePattern;
using NUnit.Framework;

namespace DesignPattern.UnitTests.State.Example1
{
    public class SelectionToolUnitTests
    {
        private Canvas canvas;
        private const string Select = "Select";
        private const string Draw = "Draw a rectangle";

        [SetUp]
        public void SetUp()
        {
            canvas = new Canvas();
            canvas.CurrentTool = new SelectionTool();
        }

        [Test]
        public void MouseDown_WhenCalled_SetResult()
        {
            canvas.MouseDown();

            Assert.That(canvas.Result, Is.EqualTo(Select));
        }

        [Test]
        public void MouseUp_WhenCalled_SetResult()
        {
            canvas.MouseUp();

            Assert.That(canvas.Result, Is.EqualTo(Draw));
        }
    }
}