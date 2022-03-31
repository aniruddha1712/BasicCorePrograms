using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    class LargestAmong3
    {
        public static void FindLargest()
        {
            int temp;
            Console.WriteLine("Enter 1st number");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int num2=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 3rd number");
            int num3=int.Parse(Console.ReadLine());

            if (num1 > num2)
                temp = num1;
            else
                temp = num2;
            if (temp > num3)
                Console.WriteLine("{0} is the largest", temp);
            else
                Console.WriteLine("{0} is the largest", num3);

                
        }
    }
}
