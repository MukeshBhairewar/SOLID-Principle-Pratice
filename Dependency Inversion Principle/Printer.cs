using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle
{
    interface IPrinter
    {
        void Print(Ishape circle);
    }
    internal class Printer : IPrinter
    {
        public void Print(Ishape circle)
        {
            Console.WriteLine(circle);
        }
    }
}
