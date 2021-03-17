using DesignPattern.StatePattern;
using NUnit.Framework;

namespace DesignPattern.UnitTests.State.Example1
{
    public class BrushToolUnitTests
    {
        private Canvas canvas;
        private const string Brush = "Brush";
        private const string BrushSomething = "Brush something";

        [SetUp]
        public void SetUp()
        {
            canvas = new Canvas();
            canvas.CurrentTool = new BrushTool();
        }

        [Test]
        public void MouseDown_WhenCalled_SetResult()
        {
            canvas.MouseDown();

            Assert.That(canvas.Result, Is.EqualTo(Brush));
        }

        [Test]
        public void MouseUp_WhenCalled_SetResult()
        {
            canvas.MouseUp();

            Assert.That(canvas.Result, Is.EqualTo(BrushSomething));
        }
    }
}