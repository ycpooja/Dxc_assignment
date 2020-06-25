using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program1
    
        {
            static void Main()
            {
                SortedList<int,string> obj = new SortedList<int,string>();
                obj.Add(9, "prakash");
                obj.Add(3, "rakesh");
                obj.Add(10, "abhisek");
                obj.Add(5, "ram");
                foreach (object k in obj.Keys)
                {
                    Console.WriteLine("Key {0} Value {1}", k);
                }
                Console.ReadKey();
            }
        }
    }