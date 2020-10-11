using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace HHKB2020
{
    class HHKB2020B
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var H = init[0];
            var W = init[1];

            var S = new char[H][];
            int result = 0;
            for (int i = 0; i < H; i++)
            {
                var L = ReadLine().ToCharArray();
                for (int j = 0; j < W - 1; j++)
                {
                    if (L[j] == '.' && L[j + 1] == '.') result++;
                }
                S[i] = L;
            }

            for (int i = 0; i < H - 1; i++)
            {
                for (int j = 0; j < W; j++)
                {
                    if (S[i][j] == '.' && S[i + 1][j] == '.') result++;
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
