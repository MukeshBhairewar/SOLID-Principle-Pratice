using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle
{

    interface Ishape
    {

    }
    interface I2Dshape:Ishape
    {
        double GetArea();
    }

    interface I3Dshape:Ishape
    {
        double GetVolume();
    }
    internal class Circle : I2Dshape
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

    internal class Rectangle : I2Dshape
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

    internal class Squre : I2Dshape
    {
        public Squre(double side)
        {
            Side = side;
        }

        public double Side { get; set; }

        public double GetArea()
        {
            return Side * Side;
        }
    }

    internal class cube : I3Dshape
    {
        public cube(double side)
        {
            Side = side;
        }

        public double Side { get; set; }

        public double GetVolume()
        {
            return Side * Side * Side;
        }
    }
}


