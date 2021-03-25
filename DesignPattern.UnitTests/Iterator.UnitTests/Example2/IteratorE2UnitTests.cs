using DesignPattern.IteratorPattern.Example2;
using NUnit.Framework;


namespace DesignPattern.UnitTests.Iterator.UnitTests.Example2
{
    public class IteratorE2UnitTests
    {
        private Profiles profiles;
        private Spammer spammer;
        private const string Result1 = "Send message to Jack";
        private const string Result2 = "Send message to Scott";
        private const string Result3 = "Send message to Jason";

        [SetUp]
        public void SetUp()
        {
            profiles = new Profiles();
            profiles.Push("Jack");
            profiles.Push("Scott");
            profiles.Push("Jason");

            spammer = new Spammer();
        }

        [Test]
        public void Spammer_Send_SendMessageToFriends()
        {
            var friendIterator = profiles.CreateFriendsIterator();
            spammer.Send(friendIterator, "spam");

            Assert.That(spammer.Result[0], Is.EqualTo(Result1));
            Assert.That(spammer.Result[1], Is.EqualTo(Result2));
            Assert.That(spammer.Result[2], Is.EqualTo(Result3));
        }
    }
}
