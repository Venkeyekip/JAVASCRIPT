using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplications
{
    class sample
    {
        public static void Main()
        {
            Console.WriteLine("enter your Name:");
            //int name = Console.Read();    -- To Print ASCI VALUE -- //

            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("My name is " + name);
            Console.ReadKey();


        }
    }
}
