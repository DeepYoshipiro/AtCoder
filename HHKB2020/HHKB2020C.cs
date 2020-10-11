using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace HHKB2020
{
    class HHKB2020C
    {
        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());
            var p = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();

            int maxP = 200000;
            var numExist = new bool[maxP + 1];

            int result = 0;
            for (int i = 0; i < N; i++)
            {
                numExist[p[i]] = true;
                while (numExist[result])
                {
                    result++;
                }
                WriteLine(result.ToString());
            }

            ReadKey();
        }
    }
}
