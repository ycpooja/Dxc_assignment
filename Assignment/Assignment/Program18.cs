using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program18
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[10];
            int i, mx, mn, n,average;
            int sum=0;

            Console.Write("Input the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }


            mx = arr1[0];
            mn = arr1[0];

            for (i = 1; i < n; i++)
            {
                if (arr1[i] > mx)
                {
                    mx = arr1[i];
                }


                if (arr1[i] < mn)
                {
                    mn = arr1[i];
                }
                sum = sum + arr1[i];
            }
            Console.WriteLine("sum is : {0}\n",sum);
            average = sum / 10;
            Console.WriteLine("average is : {0}\n",average);
            Console.WriteLine("average of marks", average);
            Console.Write("Maximum element is : {0}\n", mx);
            Console.Write("Minimum element is : {0}\n\n", mn);
            Array.Sort(arr1);
            Console.Write(arr1[i]+"");
        }
    }
}
   