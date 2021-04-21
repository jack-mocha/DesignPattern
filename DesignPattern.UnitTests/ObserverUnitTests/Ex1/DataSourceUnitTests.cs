using DesignPattern.ObserverPattern.Example1;
using NUnit.Framework;

namespace DesignPattern.UnitTests
{
    public class DataSourceUnitTests
    {
        private string ChartResult1 = "Chart Updated: 1";
        private string SheetResult1 = "SpreadSheet Updated: 1";
        private string ChartResult2 = "Chart Updated: 2";
        private string SheetResult2 = "SpreadSheet Updated: 2";
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void DataSource_SetValue_PushStyleUpdate()
        {
            var src = new DataSource();
            var chart = new Chart();
            var sheet = new SpreadSheet();
            src.AddObserver(chart);
            src.AddObserver(sheet);
            src.Value = 1;

            Assert.That(chart.Result, Is.EqualTo(ChartResult1));
            Assert.That(sheet.Result, Is.EqualTo(SheetResult1));
        }

        [Test]
        public void DataSource_SetValue_PullStyleUpdate()
        {
            var src = new DataSource();
            var chart = new Chart(src);
            var sheet = new SpreadSheet(src);
            src.AddObserver(chart);
            src.AddObserver(sheet);
            src.SetValue2(2);

            Assert.That(chart.Result, Is.EqualTo(ChartResult2));
            Assert.That(sheet.Result, Is.EqualTo(SheetResult2));
        }
    }
}