using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Basic core programs of C#");
            Console.WriteLine("1:Flipcoin\n2:LeapYear\n3:");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    FlipCoin.FindFlipCount();
                    break;
                case 2:
                    LeapYear.IsLeapYear();
                    break;
                default:
                    Console.WriteLine("Enter valid input");
                    break;
            }
            Console.ReadLine();
        }
    }
}
