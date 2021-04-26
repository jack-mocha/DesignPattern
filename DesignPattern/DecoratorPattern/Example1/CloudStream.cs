﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DecoratorPattern.Example1
{
    public class CloudStream : IStream
    {
        public string Result { get; set; }

        public void Write(string data)
        {
            Result = "Storing " + data;
        }
    }
}
