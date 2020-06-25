using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program13
    {
        static void Main(string[] args)
        {
            int square = 0;
            Console.WriteLine("enter the range");
            int range = int.Parse(Console.ReadLine());
            for(int i = 0; i < range; i++)
            {
                square = i * i;
                Console.Write(square +" ");
            }
          
        }
    }
}
