using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Student
    {
        public int sId;
        public string sName;
    }
    class Test_Student

    {
        static void Main()
        {
            Student s1 = new Student() { sId = 1, sName = "rohan" };
            Student s2 = new Student() { sId = 2, sName = "gagan" };
            Student s3 = new Student() { sId = 3, sName = "shilpa" };
            Student s4 = new Student() { sId = 4, sName = "surendra" };
            Student s5 = new Student() { sId = 5, sName = "kshema" };
            ArrayList ar = new ArrayList() { s1, s2, s3, s4, s5 };
            foreach (Student s in ar)
            {
                Console.WriteLine("ID:{0} Name {1}", s.sId, s.sName);

            }
            Console.WriteLine("Enter ID");
            int id = int.Parse(Console.ReadLine());
            int flag = 0;
            foreach (Student s in ar)
            {
                if (s.sId == id)
                {
                    Console.WriteLine("Name:" + s.sName);
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("invalid id");
            }


        }
    }
}
