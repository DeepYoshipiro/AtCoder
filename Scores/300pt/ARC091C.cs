using System;
using static System.Console;
using System.Linq;

namespace _300pt
{
    class ARC091C
    {
        static void Main(string[] args)
        {
            //input
            long[] input = ReadLine().Split(' ')
                .Select(n => long.Parse(n))
                .OrderBy(n => n).ToArray();

            long N = input[0];
            long M = input[1];

            //calculate
            long result = 0;

            if (N == 1 && M == 1) result = 1;
            else if (N == 1) result = M - 2;
            else if (M == 1) result = N - 2;
            else result = (M - 2) * (N - 2);

            //output;
            WriteLine(result.ToString());
            ReadKey();
        }

    }
}
