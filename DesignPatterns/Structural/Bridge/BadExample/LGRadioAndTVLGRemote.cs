﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge.BadExample
{
    internal class LGRadioAndTVLGRemote : RadioAndTVRemote
    {
        public override void ControlRadio()
        {
            System.Console.WriteLine("Now controlling LG radio");
        }

        public override void ControlTV()
        {
            System.Console.WriteLine("Now controlling LG TV");
        }

        public override void TurnOff()
        {
            System.Console.WriteLine("Turning LG device off");
        }

        public override void TurnOn()
        {
            System.Console.WriteLine("Turning LG device on");
        }

        public override void VolumeDown()
        {
            System.Console.WriteLine("Turning LG device volume down");
        }

        public override void VolumeUp()
        {
            System.Console.WriteLine("Turning LG device volume up");
        }
    }
}
