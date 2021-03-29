using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ObserverPattern.Example1
{
    public class Chart : IObserver
    {
        private DataSource dataSource;
        public string Result { get; set; } //Only used in unit test.

        public Chart()
        {

        }

        public Chart(DataSource dataSource)
        {
            this.dataSource = dataSource;
        }

        public void Update()
        {
            Result = "Chart Updated: " + dataSource.GetValue2();
        }

        public void Update(int value)
        {
            Result = "Chart Updated: " + value;
        }
    }
}
