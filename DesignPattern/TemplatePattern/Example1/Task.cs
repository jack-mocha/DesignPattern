using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.TemplatePattern.Example1
{
    public abstract class Task
    {
        private AuditTrail auditTrail;
        public string TaskResult { get; private set; } //Only used for unit test
        public string AuditResult { get; private set; } //Only used for unit test

        public Task()
        {
            auditTrail = new AuditTrail();
        }

        public Task(AuditTrail auditTrail)
        {
            this.auditTrail = auditTrail;
        }

        public void Execute()
        {
            AuditResult = auditTrail.Record();
            TaskResult = DoExecute();
        }

        //Use protected when you don't want other user to directly use this method(like private keyword), but it is visible to its sub-classes(inheritance).
        protected abstract string DoExecute();
    }
}
