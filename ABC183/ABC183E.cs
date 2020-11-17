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

            var S = new char[H][];
            
            long result = 0;
            long mod = (long)Pow(10, 9) + 7;

            var dpHorizon = new long[H][];
            var dpVertical = new long[H][];
            var dpCross = new long[H][];

            // 読み込み ＆ よこ
            bool stone = false;
            for (int i = 0; i < H; i++)
            {
                S[i] = ReadLine().ToCharArray();
                dpHorizon[i] = new long[W];
                dpVertical[i] = new long[W];
                dpCross[i] = new long[W];
                stone = false;
                /*
                long con = 0;
                if (S[i][j] )
                for (int j = 1; j < W; j++)
                {
                    if (!stone && S[i][j] == '.')
                    {
                        dp[i][j] = 
                    }
                }
                */

            }

            // よこ
            // たて

            // ななめ（右下方向のみ）
            // var N = long.Parse(ReadLine());
            // var init = ReadLine().Split()
            //     .Select(n => long.Parse(n)).ToArray();
            // var N = init[0];
            // var M = init[1];

            // var S = ReadLine();
            // var S = ReadLine().ToArray();

            WriteLine("Welcome to AtCoder!!");
            ReadKey();
        }
    }
}
