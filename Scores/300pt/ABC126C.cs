using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ABC126C
    {
        static void Main(string[] args)
        {
            decimal[] init = ReadLine().Split(' ')
                .Select(n => decimal.Parse(n)).ToArray();
            decimal N = init[0];
            decimal K = init[1];

            decimal result = 0;
            for (int i = 1; i <= N; i++)
            {
                decimal snukeWinPossibility = 1 / N;
                decimal snukeCurPoint = i;
                while (snukeCurPoint < K)
                {
                    snukeWinPossibility /= 2;
                    snukeCurPoint *= 2;
                }
                result += snukeWinPossibility;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}