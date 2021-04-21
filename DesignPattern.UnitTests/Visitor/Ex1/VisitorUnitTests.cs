using DesignPattern.VisitorPattern.Example1;
using NUnit.Framework;

namespace DesignPattern.UnitTests.Visitor.Ex1
{
    public class VisitorUnitTests
    {
        private string Result1 = "Highlight heading";
        private string Result2 = "Highlight anchor";
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var document = new HtmlDocument();
            var headingNode = new HeadingNode();
            var anchorNode = new AnchorNode();
            document.Add(headingNode);
            document.Add(anchorNode);

            document.Execute(new HighlightOperation());

            Assert.That(headingNode.Result, Is.EqualTo(Result1));
            Assert.That(anchorNode.Result, Is.EqualTo(Result2));
        }
    }
}