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
            Console.WriteLine("1:Flipcoin\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    FlipCoin.FindFlipCount();
                    break;
            }
            Console.ReadLine();
        }
    }
}
