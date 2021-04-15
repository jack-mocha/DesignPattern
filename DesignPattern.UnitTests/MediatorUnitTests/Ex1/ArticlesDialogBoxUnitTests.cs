using DesignPattern.MediatorPattern.Example1;
using NUnit.Framework;

namespace DesignPattern.UnitTests
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