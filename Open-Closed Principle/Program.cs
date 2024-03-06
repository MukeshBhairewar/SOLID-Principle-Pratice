using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Ishape circle = new Circle(5);
            Ishape rectangle = new Rectangle(4, 5);
            CalcuateArea(circle);
            Printer.Print(circle);
            CalcuateArea(rectangle);
            Printer.Print(rectangle);

            Console.ReadKey();
        }

        private static void CalcuateArea(Ishape circle)
        {
            Console.WriteLine(circle.GetArea());

        }
    }
}
