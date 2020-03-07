using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace EDPC {
    class EDPC_A {
        static void Main (string[] args) {
            int N = int.Parse (ReadLine ());
            int[] h = ReadLine ().Split (' ')
                .Select (n => int.Parse (n)).ToArray ();

            // 無限大の値
            const int INF = int.MaxValue;

            // DP テーブル
            int[] dp = new int[N];

            // DP テーブル全体を初期化 (最小化問題なので INF に初期化)
            for (int i = 0; i < dp.Length; i++) dp[i] = INF;

            // 初期条件
            dp[0] = 0;

            // ループ
            for (int i = 1; i < N; i++) {
                if (i >= 2) chmin (ref dp[i], dp[i - 2] + Abs (h[i - 2] - h[i]));
                if (i >= 1) chmin (ref dp[i], dp[i - 1] + Abs (h[i - 1] - h[i]));
            }

            WriteLine (dp[N - 1].ToString ());
            ReadKey ();
        }

        static bool chmin<T> (ref T a, T b) where T : IComparable<T> {
            if (b.CompareTo (a) < 0) { a = b; return true; }
            return false;
        }
    }
}