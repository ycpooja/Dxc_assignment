using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class HandsOnArea
    {
        public static void Main(string[] args)
        {
            Shape shape = new Shape();
            shape.area(10.0);
            shape.area(10.0, 20.0);
            shape.area(90);
            shape.area(50, 60);
        }
    }
}
