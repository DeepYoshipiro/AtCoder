using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _500pt
{
    class AGC001B
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => long.Parse(n)).ToArray();
            var N = init[0];
            var X = init[1];

            var A = Max(N - X, X);
            var B = Min(N - X, X);
            var R = A;

            long result = 0;
            while (R > 0)
            {
                R = A % B;
                result += A - R;
                A = B;
                B = R;
            }
            result *= 3;

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}