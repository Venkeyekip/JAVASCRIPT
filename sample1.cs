using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplications
{
    class sample1
    {
        public static void Main()
        {
            Console.Write("Enter Eno: ");
            string Eno = Console.ReadLine();
            Console.Write("Enter Ename: ");
            string Ename = Console.ReadLine();
            Console.Write("Enter Salary: ");
            string Salary = Console.ReadLine(); 
            Console.Write("Enter Increment: ");
            string Inc = Console.ReadLine();    
            Console.WriteLine("Total Salary = " + (Salary + (Inc)));
            string tot = Console.ReadLine();
            Console.WriteLine("Employee No is: " + Eno + ", Employee Name is: " + Ename + " and Salary is: " + Salary);
            Console.ReadKey();


        }
    }
}
