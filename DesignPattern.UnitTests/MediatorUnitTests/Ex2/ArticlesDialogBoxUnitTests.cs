using DesignPattern.MediatorPattern.Example2;
using NUnit.Framework;

namespace DesignPattern.UnitTests.MediatorUnitTests.Ex2
{
    public class ArticlesDialogBoxUnitTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var dialog = new ArticlesDialogBox();
            dialog.SimulateUserInteraction();
        }
    }
}