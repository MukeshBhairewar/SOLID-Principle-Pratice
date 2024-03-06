using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISKOV_S_Substitution_Principle
{
    interface Ishape
    {
        double GetArea();
    }

    internal class Circle : Ishape
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; set; }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    internal class Rectangle : Ishape
    {
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double Length { get; set; }

        public double Width { get; set; }

        public double GetArea()
        {
            return Length * Width;
        }
    }

    internal class Squre : Ishape
    {
        public Squre(double side)
        {
            Side = side;
        }

        public double Side { get; set; }

        public double GetArea()
        {
            return Side*Side;
        }
    }
}
