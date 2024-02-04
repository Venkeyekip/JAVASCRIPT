using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplications
{
    class sample14
    {
        public static void Main()
        {
            int[] ar = new int[] { 12, 21, 21, 32, 21, 12, 21, 21 };
            int size = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] % 2 == 0)
                {
                    size++;
                }
            }
            int[] br = new int[size];
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] % 2 == 0)
                {
                    br[i] = ar[i];
                }
            }
        }
    }
}

