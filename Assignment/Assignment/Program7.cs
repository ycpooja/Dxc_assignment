using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program7
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            int large;


            Console.Write("Enter first number : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number : ");
            c = Convert.ToInt32(Console.ReadLine());


            if (a > b && a > c)
                large = a;
            else if (b > a && b > c)
                large = b;
            else large = c;


            Console.WriteLine("Using if-else...");
            Console.WriteLine("Largest number is {0}", large);
            Console.ReadLine();
        }
    }
}

   