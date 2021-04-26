using DesignPattern.IteratorPattern.Example1;
using NUnit.Framework;
using System.Collections.Generic;

namespace DesignPattern.UnitTests.Iterator.UnitTests.Example1
{
    public class DecoratorE1UnitTests
    {
        private BrowseHistory history;
        private List<string> results = new List<string>();
        private const string Result1 = "a";
        private const string Result2 = "b";
        private const string Result3 = "c";

        [SetUp]
        public void Setup()
        {
            history = new BrowseHistory();
            history.Push("a");
            history.Push("b");
            history.Push("c");
        }

        [Test]
        public void Test1()
        {
            var iterator = history.CreateIterator();
            while (iterator.HasNext())
            {
                var url = iterator.Current();
                results.Add(url);
                iterator.Next();
            }

            Assert.That(results[0], Is.EqualTo(Result1));
            Assert.That(results[1], Is.EqualTo(Result2));
            Assert.That(results[2], Is.EqualTo(Result3));
        }
    }
}