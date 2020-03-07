using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace BlueProblems
{
    class ABC037D
    {
        static long[, ] dp;
        static int H;
        static int W;

        static int[, ] a;

        static long MOD;

        static void Main(string[] args)
        {
            ABC037D my = new ABC037D();
            MOD = (long)Pow(10, 9) + 7;
            int[] init = ReadLine().Split()
                    .Select(m => int.Parse(m)).ToArray();
            H = init[0];
            W = init[1];

            a = new int[H, W];
            dp = new long[H, W];
            for (int i = 0; i < H; i++)
            {
                string[] s = ReadLine().Split();
                for (int j = 0; j < W; j++)
                {
                    a[i, j] = int.Parse(s[j]);
                }
            }

            long result = 0;
            for (int h = 0; h < H; h++)
            {
                for (int w = 0; w < W; w++)
                {
                    result += my.GetRouteCnt(h, w);
                    result %= MOD;
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }

        long GetRouteCnt(int h, int w)
        {
            if (dp[h, w] > 0) return dp[h, w];

            long result = 1;
            dp[h, w] = 1;

            int[] dh = {-1, 0, 0, 1};
            int[] dw = {0, -1, 1, 0};
            for (int i = 0; i < dh.Length; i++)
            {
                int moveToH = h + dh[i];
                int moveToW = w + dw[i];
                if (moveToH < 0 || moveToH >= H) continue;
                if (moveToW < 0 || moveToW >= W) continue;
                if (a[h, w] < a[moveToH, moveToW])
                {
                    if (dp[moveToH, moveToW] > 0)
                    {
                        result += dp[moveToH, moveToW];
                    }
                    else
                    {
                        result += GetRouteCnt(moveToH, moveToW);
                    }
                    result %= MOD;
                    dp[h, w] = result;
                }
            }

            dp[h, w] = result;
            return result;
        }
    }
}
