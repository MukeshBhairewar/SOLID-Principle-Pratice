using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle
{
    public class Circle
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; set; }


        public double GetArea()
        {
            return Radius * Radius;
        }
    }
}
