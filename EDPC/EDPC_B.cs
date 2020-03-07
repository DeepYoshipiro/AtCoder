using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace EDPC
{
    class EDPC_B
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int K = init[1];

            int[] h = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();

            // 無限大の値
            const int INF = int.MaxValue;

            // DP テーブル
            int[] dp = new int[N + K + 1];

            // DP テーブル全体を初期化 (最小化問題なので INF に初期化)
            for (int i = 0; i < dp.Length; i++) dp[i] = INF;

            // 初期条件
            dp[0] = 0;
            dp[1] = 0;

            for (int i = 1; i < N; i++)
            {
                for (int j = 1; j <= K; j++)
                {
                    if (i + j <= N)
                        chmin(ref dp[i + j], dp[i] + Abs(h[i - 1] - h[i + j - 1]));
                }
            }

            WriteLine(dp[N].ToString());
            ReadKey();
        }

        static bool chmin<T>(ref T a, T b) where T : IComparable<T>
            {
                if (b.CompareTo(a) < 0)
                {
                    a = b;
                    return true;
                }
                return false;
            }

    }
}