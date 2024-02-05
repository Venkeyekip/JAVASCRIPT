using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplications
{
    class sample17
    {
        int empid;
        string EmpName;
        double Empsalary;
        int EmpExp;
        string EmpGender;

        public void GetEmpData()
        {
            Console.WriteLine("Enter Employee Details: ");
            empid = Convert.ToInt32(Console.ReadLine());
            EmpName= Console.ReadLine();
            Empsalary = Convert.ToDouble(Console.ReadLine());
            EmpExp = Convert.ToInt32(Console.ReadLine());
            EmpGender = Console.ReadLine();
        }
        public void DisplayEmpData()
        {
            Console.WriteLine($"EmpID: {empid}\nEmpName: {EmpName}\nEmpSalary: {Empsalary}\nExperiecne: {EmpExp}\nGender: {EmpGender}");
        }
        public string Greet()
        {
            return "Welcome to C# OOPS";
        }

    }

    class Program
    {
        static void Main()
        {
            sample17 obj1 = new sample17();
            obj1.GetEmpData();
            obj1.DisplayEmpData();
            obj1.Greet();



             sample17 obj2 = new sample17();
            obj2.GetEmpData();
            obj2.DisplayEmpData();


        }
    }
}
