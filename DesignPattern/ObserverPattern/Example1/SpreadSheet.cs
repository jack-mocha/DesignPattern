using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ObserverPattern.Example1
{
    public class SpreadSheet : IObserver
    {
        private DataSource dataSource;
        public string Result { get; set; } //Only used in unit test.

        public SpreadSheet()
        {

        }

        public SpreadSheet(DataSource dataSource)
        {
            this.dataSource = dataSource;
        }

        public void Update()
        {
            Result = "SpreadSheet Updated: " + dataSource.GetValue2();
        }

        public void Update(int value)
        {
            Result = "SpreadSheet Updated: " + value;
        }
    }
}
