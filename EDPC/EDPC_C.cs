using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace EDPC
{
    class EDPC_C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());

            int[][] happiness = new int[N + 1][];
            happiness[0] = new int[]{0,0,0};
            for (int i = 1; i <= N; i++)
            {
                happiness[i] = ReadLine().Split(' ')
                    .Select(n => int.Parse(n)).ToArray();
            }

            // DP テーブル
            int[][] dp = new int[N + 1][];

            // DP テーブル全体を初期化 (最大化問題なので 0 に初期化)
            for (int i = 0; i < dp.Length; i++)
                dp[i] = new int[3]{0,0,0};

            // 初期条件
            dp[1] = happiness[1];

            // DP本体
            for (int i = 1; i < N; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (j == k) continue;
                        chmax(ref dp[i + 1][k], dp[i][j] + happiness[i + 1][k]);
                    }
                }
            }

            int result = dp[N][0];
            chmax(ref result, dp[N][1]);
            chmax(ref result, dp[N][2]);
            
            WriteLine(result.ToString());
            ReadKey();
        }

        static bool chmax<T>(ref T a, T b) where T : IComparable<T>
        {
            if (b.CompareTo(a) > 0)
            {
                a = b;
                return true;
            }
            return false;
        }
    }
}