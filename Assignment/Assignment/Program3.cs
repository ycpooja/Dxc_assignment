using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program3
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the number of elements");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine("count of evn number", count);
                }
                else
                {
                    Console.WriteLine("count of odd number", count);

                }
            }
        }
    }

}
  