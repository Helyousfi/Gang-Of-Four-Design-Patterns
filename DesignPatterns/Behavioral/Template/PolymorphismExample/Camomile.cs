﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Template.PolymorphismExample
{
    internal class Camomile : Beverage
    {
        public void Prepare()
        {
            Brew();
        }

        public void Brew()
        {
            System.Console.WriteLine("Brewing for 3 mins");
        }
    }
}
