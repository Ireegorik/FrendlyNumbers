using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FrendlyNumbers
{
    class Frendly
    {
        public static void GetFrendlies( int k)
        {
            int firstSumm;
            int secondSumm;
            for (int i = 220; i <= k; i++)
            {
                firstSumm = 0;
                secondSumm = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0) firstSumm += j;
                    if (firstSumm > k) break;
                }
                if ((firstSumm > i) && (firstSumm <= k))
                {
                    for (int j = 1; j < firstSumm; j++)
                    {
                        if (firstSumm % j == 0) secondSumm += j;
                        if (firstSumm > k) break;
                    }
                    if (secondSumm == i) Console.WriteLine($"{i} {firstSumm}");
                }
            }
        }

    }
}
