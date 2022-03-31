using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    class CheckVowel
    {
        public static void CheckAlphabet()
        {
            Console.WriteLine("enter any Alphabet");
            char alpha = char.ToLower(Convert.ToChar(Console.ReadLine()));
            switch(alpha)
            {
                case 'a':
                    Console.WriteLine("'a' is vowel");
                    break;
                case 'e':
                    Console.WriteLine("'e' is vowel");
                    break;
                case 'i':
                    Console.WriteLine("'i' is vowel");
                    break;
                case 'o':
                    Console.WriteLine("'o' is vowel");
                    break;
                case 'u':
                    Console.WriteLine("'u' is vowel");
                    break;
                default:
                    Console.WriteLine("Not a vowel");
                    break;
            }
        }
    }
}
