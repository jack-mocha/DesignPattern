using DesignPattern.FlyweightPattern.Example1;
using NUnit.Framework;
using System.Collections.Generic;

namespace DesignPattern.UnitTests.Flyweight.Ex1
{
    public class FlyweightE1UnitTests
    {
        private string Result = "Cafe at (1, 2)";

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Point_WhenDraw_ReturnCoordinates()
        {
            var service = new PointService(new PointIconFactory());
            var result = "";
            foreach (var point in service.GetPoints())
            {
                result = point.Draw();
            }

            Assert.That(result, Is.EqualTo(Result));
        }
    }
}