using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC197
{
    class ABC197B
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var H = init[0];
            var W = init[1];
            var X = --init[2];
            var Y = --init[3];

            var S = new char[H][]
                    .Select(v => new char[W]).ToArray();
            for (int i = 0; i < H; i++)
            {
                S[i] = ReadLine().ToCharArray();
            }

            int result = 0;
            for (int up = X; up >= 0; up--)
            {
                if (S[up][Y] == '.') result++;
                else break;
            }

            for (int down = X + 1; down < H; down++)
            {
                if (S[down][Y] == '.') result++;
                else break;
            }

            for (int left = Y - 1; left >= 0; left--)
            {
                if (S[X][left] == '.') result++;
                else break;
            }

            for (int right = Y + 1; right < W; right++)
            {
                if (S[X][right] == '.') result++;
                else break;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
