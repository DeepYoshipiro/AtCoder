using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC146
{
    class ABC146Crev
    {
        static void Main(string[] args)
        {
            long[] init = ReadLine().Split(' ')
                .Select(n => long.Parse(n)).ToArray();
            long A = init[0];
            long B = init[1];
            long X = init[2];

            long N = (long)Pow(10, 9);
            if (A * N + B * 10 <= X)
            {
                WriteLine(N.ToString());
                ReadKey();
                return;
            }

            long overBudget = N;
            long ableBuy = 0;
            while (overBudget - ableBuy > 1)
            {
                N = (overBudget + ableBuy) / 2;
                long digitN = (long)Log10(N) + 1;
                if (A * N + B * digitN <= X)
                {
                    ableBuy = N;
                }
                else
                {
                    overBudget = N;
                }
            }
            WriteLine(ableBuy.ToString());
            ReadKey();
        }
    }
}
