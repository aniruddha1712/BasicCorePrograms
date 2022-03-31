using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    class OddEven
    {
        public static void FindOddOrEven()
        {
            Console.WriteLine("Enter any integer value");
            int num=int.Parse(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine("Number is even");
            else
                Console.WriteLine("Number is odd");

        }
    }
}
