using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt {
    class ARC129C {
        static void Main (string[] args) {
            int[] init = ReadLine ().Split (' ')
                .Select (n => int.Parse (n)).ToArray ();
            int N = init[0];
            int M = init[1];

            bool[] stairUse = new bool[N + 3];
            for (int i = 0; i < N + 3; i++) {
                stairUse[i] = true;
            }

            for (int i = 0; i < M; i++) {
                int b = int.Parse (ReadLine ());
                stairUse[b] = false;
            }

            long[] dp = new long[N + 3];
            dp[0] = 1;

            for (int i = 0; i <= N - 1; i++) {
                if (!stairUse[i]) continue;

                if (stairUse[i] && stairUse[i + 1]) {
                    dp[i + 1] += dp[i];
                    dp[i + 1] %= 1000000007;
                } else dp[i + 1] = 0;

                if (stairUse[i] && stairUse[i + 2]) {
                    dp[i + 2] += dp[i];
                    dp[i + 2] %= 1000000007;
                } else dp[i + 2] = 0;
            }

            WriteLine (dp[N].ToString ());
            ReadKey ();
        }

    }
}