using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    class HarmonicNum
    {
        public static void FindHarmonicNumber()
        {
            Console.WriteLine("Enter the value of N");
            double term=0;
            int num = Convert.ToInt32(Console.ReadLine());

            for (double i=1;i<=num;i++)
            {
                term = term+1 / i;
            }
            Console.WriteLine("Nth harmonic number is{0}",term);


        }
    }
}
