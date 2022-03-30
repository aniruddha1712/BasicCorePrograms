using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    class LeapYear
    {
        public static void IsLeapYear()
        {
            Console.WriteLine("Enter any year:");
            int year=Convert.ToInt32(Console.ReadLine());

            if(year%400==0)
            {
                Console.WriteLine(year+" is a leap year");
            }
            else if(year%4==0 && year%100!=0)
            {
                Console.WriteLine(year+" is a leap year");
            }
            else
                Console.WriteLine(year+" is not a leap year");
        }
    }
}
