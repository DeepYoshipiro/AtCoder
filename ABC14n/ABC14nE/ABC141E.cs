using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC141
{
    class ABC141E
    {
        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());
            string S = ReadLine();
            var Letter = new List<int>['z' - 'a' + 1]
                .Select(v => new List<int>()).ToArray();

            for (int i = 0; i < N; i++) 
            {
                Letter[char.Parse(S.Substring(i, 1)) - 'a'].Add(i);
            }

            var dp = new int[N + 1][];
            dp[N] = new int[N];
            int result = 0;
            for (int i = N - 1; i > 0; i--)
            {
                dp[i] = new int[i];
                var L = Letter[char.Parse(S.Substring(i, 1)) - 'a'];
                foreach (int j in L)
                {
                    if (j >= i) break;
                    dp[i][j] = Min(dp[i + 1][j + 1] + 1, i - j);
                    if (dp[i][j] > result) result = dp[i][j];
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
