using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC156
{
    class ABC156B
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int K = init[1];

            int digit = 0;
            while (N > 0)
            {
                digit++;
                N /= K;
            }

            WriteLine(digit.ToString());
            ReadKey();
        }
    }
}
