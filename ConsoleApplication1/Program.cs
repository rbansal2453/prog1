using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Student
    {
        public string FirstName, LastName;
        public static int num;
        public Student()
        {
            num++;
        }
        public static int GetNum()
        {
            return num;
        }
        public void PrintFullName(string FirstName , string LastName)
        {
            string FullName;
            FullName = FirstName + " " + LastName;
            Console.WriteLine("FullName: {0}", FullName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            Student s1 = new Student();
            Student s2 = new Student();
            s.PrintFullName("Rajesh", "Bansal");
            s1.PrintFullName("r", "b");
            s2.PrintFullName("b", "r");
            Console.WriteLine("Total No Of Students: {0}", Student.GetNum());
            Console.ReadLine();

        }
    }
}
