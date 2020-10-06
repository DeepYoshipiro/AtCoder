// Solution : Digit DP
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _500pt
{
    class ABC129E
    {
        static void Main(string[] args)
        {
            var L = (new char[]{' '})
                .Concat(ReadLine()).ToArray();

            var digit = L.Length - 1;
            var dpJustL = new long[digit + 1];
            var dpUnderL = new long[digit + 1];

            dpJustL[1] = 2;
            dpUnderL[1] = 1;

            long MOD = (long)Pow(10, 9) + 7;
            for (int i = 2; i <= digit; i++)
            {
                switch (L[i])
                {
                    case '0':
                        dpJustL[i] = dpJustL[i - 1];
                        dpUnderL[i] = dpUnderL[i - 1] * 3;
                        break;
                    case '1':
                        dpJustL[i] = dpJustL[i - 1] * 2;
                        dpUnderL[i]
                         = dpJustL[i - 1] + dpUnderL[i - 1] * 3;
                        break;
                }
                dpJustL[i] %= MOD;
                dpUnderL[i] %= MOD;
            }

            var result = dpJustL[digit] + dpUnderL[digit];
            result %= MOD;

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
