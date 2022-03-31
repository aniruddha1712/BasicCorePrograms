using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    class SwapNumbers
    {
        public static void Swap2Numbers()
        {
            int first, second, temp = 0;
            Console.WriteLine("please enter first number");
            first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter second number");
            second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swap.....First:{0} Second:{1}", first, second);
            temp = first;
            first = second;
            second = temp;
            Console.WriteLine("Afer swap.....First:{0} Second:{1}", first, second);
        }
    }
}
