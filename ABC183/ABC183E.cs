using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC183
{
    class ABC183E
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var H = init[0];
            var W = init[1];

            var S = new char[H + 1][];
            
            var dpWay = new long[H + 1][];
            long mod = (long)Pow(10, 9) + 7;

            var dpSumH = new long[H + 1][];
            var dpSumW = new long[H + 1][];
            var dpSumC = new long[H + 1][];

            dpWay[0] = new long[W + 1];
            dpSumH[0] = new long[W + 1];
            dpSumW[0] = new long[W + 1];
            dpSumC[0] = new long[W + 1];

            for (int i = 1; i <= H; i++)
            {
                S[i] = (new char[]{' '}).Concat(ReadLine()).ToArray();

                dpWay[i] = new long[W + 1];
                dpSumH[i] = new long[W + 1];
                dpSumW[i] = new long[W + 1];
                dpSumC[i] = new long[W + 1];

                for (int j = 1; j <= W; j++)
                {
                    if (S[i][j] == '#')
                    {
                        dpSumH[i][j] = 0;
                        dpSumW[i][j] = 0;
                        dpSumC[i][j] = 0;
                        dpWay[i][j] = 0;
                        continue;
                    }

                    dpWay[i][j] = (dpSumH[i - 1][j]
                                    + dpSumW[i][j - 1]
                                    + dpSumC[i - 1][j - 1]) % mod;

                    if (i == 1 && j == 1)
                    {
                        dpWay[i][j] = 1;
                    }

                    dpSumH[i][j] = (dpSumH[i - 1][j] + dpWay[i][j]) % mod;
                    dpSumW[i][j] = (dpSumW[i][j - 1] + dpWay[i][j]) % mod;
                    dpSumC[i][j] = (dpSumC[i - 1][j - 1] + dpWay[i][j]) % mod;
                }
            }

            WriteLine(dpWay[H][W].ToString());
            ReadKey();
        }
    }
}
