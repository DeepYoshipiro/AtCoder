using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC158
{
    class ABC158B
    {
        static void Main(string[] args)
        {
            long[] init = ReadLine().Split()
                .Select(n => long.Parse(n)).ToArray();
            long N = init[0];
            long A = init[1];
            long B = init[2];

            long result = (N / (A + B)) * A;
            result += (N % (A + B) > A ? A : N % (A + B));
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
