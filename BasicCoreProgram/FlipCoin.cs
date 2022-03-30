using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    class FlipCoin
    {
        public static void FindFlipCount()
        {
            int tails = 0, heads = 0;
            Random random = new Random();
            Console.WriteLine("Enter number of times to flipcoin");
            int numbOfTimes = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= numbOfTimes; i++)
            {
                double input = random.NextDouble();
                if (input < 0.5)
                    tails++;
                else
                    heads++;
            }
            Console.WriteLine("heads:{0} tails:{1}", heads, tails);
            double tailPercentage = (tails * 100) / numbOfTimes;
            double headPercentage = (heads * 100) / numbOfTimes;
            Console.WriteLine("Head Percentage:{0}% tail Percentage:{1}%", headPercentage, tailPercentage);
        }
    }
}
