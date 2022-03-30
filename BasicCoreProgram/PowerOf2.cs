using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    class PowerOf2
    {
        public static void FindPower()
        {
            Console.WriteLine("Enter the value of n(power)");
            int power=Convert.ToInt32(Console.ReadLine());
            if(power<=31 && power>0)
            {
                for(int i=0;i<=power;i++)
                {
                    int num = (int) Math.Pow(2, i);
                    Console.WriteLine("2^"+i +"="+num);
                }
            }
            else
                    Console.WriteLine("Enter power between 0 and 31");

        }
    }
}
