﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Classes.TheHouse
{
    class Walls : Interfaces.IPart
    {
        public void bePart()
        {
            Console.WriteLine("Walls now is a part of house");
        }

        public void intallingPart()
        {
            Console.WriteLine("installingPart()");
        }

        public void removingPart()
        {
            Console.WriteLine("removingPart()");
        }
    }
}
