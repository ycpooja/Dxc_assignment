using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program10
    {

        static void Main()
        {
            int n1, n2, n3;
            Console.WriteLine("Enter Three no:");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine());
            if (n1 < n2)
                if (n1 < n3)
                {
                    Console.WriteLine("The Smallest Of Three numbers are:" + n1);
                }
                else
                {
                    Console.WriteLine("The Smallest Of Three numbers are:" + n3);
                }
            else
                if (n2 < n3)
            {
                Console.WriteLine("The Smallest Of Three numbers are:" + n2);
            }
            else
            {
                Console.WriteLine("The Smallest Of Three numbers are:" + n3);
            }
        }
    }
}
