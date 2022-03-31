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
            Console.WriteLine("1:Flipcoin\n2:LeapYear\n3:FindPOwerOf2\n4:HarmonicNumber\n5:PrimeNumbers\n6:FindQuotientAndRemainder\n7:SwapNumbers\n8:OddEven\n9:CheckVowel\n10:LaregestAmongThree");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    FlipCoin.FindFlipCount();
                    break;
                case 2:
                    LeapYear.IsLeapYear();
                    break;
                case 3:
                    PowerOf2.FindPower();
                    break;
                case 4:
                    HarmonicNum.FindHarmonicNumber();
                    break;
                case 5:
                    PrimeFactors.FindPrimeFactors();
                    break;
                case 6:
                    RemAndQuotient.FindRemAndQuotient();
                    break;
                case 7:
                    SwapNumbers.Swap2Numbers();
                    break;
                case 8:
                    OddEven.FindOddOrEven();
                    break;
                case 9:
                    CheckVowel.CheckAlphabet();
                    break;
                case 10:
                    LargestAmong3.FindLargest();
                    break;
                default:
                    Console.WriteLine("Enter valid input");
                    break;
            }
            Console.ReadLine();
        }
    }
}
