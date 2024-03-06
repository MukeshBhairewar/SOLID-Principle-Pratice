using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Circle circle = new Circle(5);
            CalculateArea(circle);
            Printer.Print(circle);
        }

        private static void CalculateArea(Circle circle)
        {
            Console.WriteLine(circle.GetArea());
        }
    }

}
