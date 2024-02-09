using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplications
{
    class sample18
    {
        int studentid;
        string studentName;
        string studentC_Name;
        string studentSubject;
        double studentMarks;

        public void GetEmpData()
        {
            Console.WriteLine("Enter student Details:");
            studentid = Convert.ToInt32(Console.ReadLine());
            studentName = Console.ReadLine();
            studentC_Name = Console.ReadLine();
            studentSubject = Console.ReadLine();
            studentMarks = Convert.ToDouble(Console.ReadLine());


                }
        public void DisplayEmpData()
        {
            Console.WriteLine($"StuId:{studentid},StuName:{studentName},StudentC_Name:{studentC_Name},StudentSubject:{studentSubject},StudentMarks:{studentMarks}");

        }
        public string Greet()
        {
            return "Welcome To C# Programing";
        }
        public static void Main()
        {
            sample18 obj = new sample18();
            obj.Greet();
            obj.GetEmpData();
            obj.DisplayEmpData();
            obj.Greet();

        }
    }
  
}
