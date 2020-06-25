using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        { 
                List<string> names = new List<string>();
                {
                    names.Add("manogna");
                    names.Add("arya");
                    names.Add("maina");
                    names.Add("sana");
                    names.Add("lily");


                    names.Sort();
                    names.Reverse();

                    foreach (string name in names)
                    {
                        Console.WriteLine(name);

                    }
                    Console.ReadKey();
                }

            }
        }
    }
