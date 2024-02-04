using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplications
{
    class sample13
    {
        public static void Main()
        {
            Console.WriteLine("Enter Size Of Array");
            int size = Convert.ToInt32(Console.ReadLine());
            string[] strArray = new string[size];

            for(int i=0;i<size; i++)
            {
                Console.WriteLine($"enter {i+1} elements");
                strArray[i] = Console.ReadLine();
            }
            Console.WriteLine("elements of Array are:");
            int j = 0;
            while(j< size)
            {
                Console.WriteLine(strArray[j]+"  ");
            }
        }
    }
}
