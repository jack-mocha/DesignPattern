using DesignPattern.AdapterPattern.Example1;
using DesignPattern.AdapterPattern.Example1.AvaFilters;
using DesignPattern.ChainOfResponsibilityPattern.Example1;
using NUnit.Framework;

namespace DesignPattern.UnitTests.Adapter.Ex1
{
    public class AdapterUnitTests
    {
        private string Result;
        [SetUp]
        public void Setup()
        {
            Result = "Applying Caramel Filter";
        }

        [Test]
        public void Composition_WhenCalled_FilterApplied()
        {
            var imageView = new ImageView(new Image());
            var caramel = new Caramel();

            imageView.Apply(new CaramelFilter(caramel));

            Assert.That(caramel.Result, Is.EqualTo(Result));
        }

        [Test]
        public void ThreeHandler_WhenCalled_AllReturnTrue()
        {
            var imageView = new ImageView(new Image());
            var adapter = new CaramelAdapter();

            imageView.Apply(adapter);

            Assert.That(adapter.Result, Is.EqualTo(Result));

        }
    }
}