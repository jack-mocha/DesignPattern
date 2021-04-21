using DesignPattern.CommandPattern.Example1.FX;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CommandPattern.Example1
{
    public class AddCustomerCommand : ICommand
    {
        private CustomerService Service;
        public string Result { get; set; } //This is for unit testing only.

        public AddCustomerCommand(CustomerService service)
        {
            Service = service;
        }

        public void Execute()
        {
            Result = Service.AddCustomer();
        }
    }
}
