using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    class PrimeFactors
    {
        public static void FindPrimeFactors()
        {
            Console.WriteLine("Enter any number to find prime factors");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i=2; num>1; i++)
            {
                if (num%i==0)
                {
                    int temp = 0;
                    while(num%i==0)
                    {
                        num /= i;
                        temp++;
                    }
                Console.WriteLine("{0} is a prime factor of {1} times!",i,temp);
                }
            }
        }
    }
}
