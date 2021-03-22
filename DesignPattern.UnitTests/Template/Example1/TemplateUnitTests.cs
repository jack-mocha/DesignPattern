using DesignPattern.TemplatePattern.Example1;
using NUnit.Framework;

namespace DesignPattern.UnitTests.Template.Example1
{
    public class TemplateUnitTests
    {
        private const string TaskResult = "Transfer Money"; 
        private const string AuditResult = "AuditTrail"; 

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Execute_WhenCalled_RecordAuditAndTransfer()
        {
            var task = new TransferMoneyTask();
            task.Execute();

            Assert.That(task.AuditResult, Is.EqualTo(AuditResult));
            Assert.That(task.TaskResult, Is.EqualTo(TaskResult));
        }
    }
}