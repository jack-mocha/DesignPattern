using DesignPattern.CommandPattern.Example1;
using DesignPattern.CommandPattern.Example1.FX;
using NUnit.Framework;

namespace DesignPattern.UnitTests.Command.Example1
{
    public class CommandE1UnitTests
    {
        private string Result;

        [SetUp]
        public void Setup()
        {
            Result = "Added Customer A.";
        }

        [Test]
        public void Button_Clicked_AddUser()
        {
            var command = new AddCustomerCommand(new CustomerService());
            var button = new Button(command);

            button.Click();

            Assert.That(command.Result, Is.EqualTo(Result));
        }
    }
}