using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program5
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 1, num3, i, number;
            Console.Write("Enter the number of elements you want to print: ");
            number = int.Parse(Console.ReadLine());

            Console.Write(num1 + " " + num2 + " ");

            for (i = 2; i < number; ++i)
            {
                num3 = num1 + num2;
                Console.Write(num3 + " ");
                num1 = num2;
                num2 = num3;
            }

            Console.ReadLine();
        }
    }
}

   