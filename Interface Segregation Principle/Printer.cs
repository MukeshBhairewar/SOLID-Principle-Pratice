﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle
{
    internal class Printer
    {
        public static void Print(Ishape circle)
        {
            Console.WriteLine(circle);

        }
    }
}
