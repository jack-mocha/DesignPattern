using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.TemplatePattern.Example1
{
    public class TransferMoneyTask : Task
    {
        ////You can use this if you want to supply a different implementation of IAuditTrail
        //public TransferMoneyTask(AuditTrail auditTrail) : base(auditTrail)
        //{
        //}

        protected override string DoExecute()
        {
            return "Transfer Money";
        }
    }
}
