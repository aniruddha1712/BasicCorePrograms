using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    class RemAndQuotient
    {
        public static void FindRemAndQuotient()
        {
            Console.WriteLine("Enter any number:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter divisor:");
            int div= int.Parse(Console.ReadLine());

            int rem = num%div;
            int quotient = num / div;

            Console.WriteLine("Quotient= {0} and Remainder={1}",quotient,rem);
        }
    }
}
