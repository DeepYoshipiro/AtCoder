using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC146
{
    class ABC146C
    {
        static void Main(string[] args)
        {
            long[] init = ReadLine().Split(' ')
                .Select(n => long.Parse(n)).ToArray();
            long A = init[0];
            long B = init[1];
            long X = init[2];

            long maxPrice = 0;
            long result = 0;
            for (long d = 18; d >= 1; d--)
            {
                maxPrice = X - B * d;
                long maxN = maxPrice / A;
                if (maxN >= Pow(10, d - 1))
                {
                    if (maxN >= Pow(10, d))
                    {
                        maxN = (long)Pow(10, d) - 1;
                    }
                    result = maxN;
                    break;
                }
            }

            if (result > Pow(10, 9)) result = (long)Pow(10, 9);
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
