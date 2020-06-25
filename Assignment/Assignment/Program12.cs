using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program12
    {
        static void Main(string[] args)
        {
            int x = Int32.Parse(args[0]);
            int y = Int32.Parse(args[0]);

            for(int i = x; i < y; i++)
            {
                Console.WriteLine(i);

            }
            Console.ReadLine();
        }
    }
}
