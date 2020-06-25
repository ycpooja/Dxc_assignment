using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Shape
    {
        public void area(float x)
        {
            Console.WriteLine("the area of the square is " + Math.Pow(3,2) + " sq units");
        }
        public void area(float x, float y)
        {
            Console.WriteLine("the area of the rectangle is " + x * y + " sq units");
        }
        public void area(double x)
        {
            double z = 3.14 * x * x;
            Console.WriteLine("the area of the circle is " + z + " sq units");
        }
        public void area(double x,double y)
        {
            double a = (x * y)/2;
            Console.WriteLine("the area of the triangle is " + a + " sq units");
        }
    }
}
