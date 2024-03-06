using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            I3Dshape cube = new cube(5);
            I2Dshape circle = new Circle(5);
            CalcuateArea(circle);
            IPrinter printer = new Printer();
            printer.Print(cube);    
            CalcuateVolume(cube);
            Console.ReadKey();
        }

        private static void CalcuateArea(I2Dshape circle)
        {
            Console.WriteLine(circle.GetArea());

        }

        private static void CalcuateVolume(I3Dshape circle)
        {
            Console.WriteLine(circle.GetVolume());

        }
    }
}
