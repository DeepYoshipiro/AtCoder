using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC165
{
    class ABC165D
    {
        static void Main(string[] args)
        {
            long[] init = ReadLine().Split()
                .Select(n => long.Parse(n)).ToArray();
            long A = init[0];
            long B = init[1];
            long N = init[2];

            long rest = N % B;
            if (B <= N)
            {
                N -= rest + 1;
            }
            long result = (A * N) / B;
            result -= A * (N / B);

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
