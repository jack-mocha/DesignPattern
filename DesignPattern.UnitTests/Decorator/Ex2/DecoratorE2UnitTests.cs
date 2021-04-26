using DesignPattern.DecoratorPattern.Example2;
using NUnit.Framework;
using System.Collections.Generic;

namespace DesignPattern.UnitTests.Decorator.Ex2
{
    public class DecoratorE2UnitTests
    {
        private string data;
        private string Result1;
        private string Result2;
        private string Result3;

        [SetUp]
        public void Setup()
        {
            data = "123121231-23123132313-1231321321-1231231123";
            Result1 = "Storing " + data;
            Result2 = "Storing 12312";
            Result3 = "Storing @#)$(";
        }

        [Test]
        public void StoreCreditCard_PlainText_ReturnPlainText()
        {
            var component = new CloudStream();
            var manager = new Manager();
            manager.StoreCreditCard(component, data);

            Assert.That(component.Result, Is.EqualTo(Result1));
        }

        [Test]
        public void StoreCreditCard_Compress_ReturnCompressed()
        {
            var component = new CloudStream();
            var manager = new Manager();
            manager.StoreCreditCard(new CompressedStream(component), data);

            Assert.That(component.Result, Is.EqualTo(Result2));
        }

        [Test]
        public void StoreCreditCard_EncryptandCompress_ReturnEncryptedCompressed()
        {
            var component = new CloudStream();
            var manager = new Manager();
            manager.StoreCreditCard(new EncryptedStream(new CompressedStream(component)), data);

            Assert.That(component.Result, Is.EqualTo(Result3));
        }
    }
}