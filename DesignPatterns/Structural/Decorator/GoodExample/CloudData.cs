﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator.GoodExample
{
    internal class CloudData : Data
    {
        private string _url;

        public CloudData(string url)
        {
            _url = url;
        }

        public void Save(string data)
        {
            System.Console.WriteLine($"Saving data '{data}' to cloud at '{_url}'");
        }
    }
}
