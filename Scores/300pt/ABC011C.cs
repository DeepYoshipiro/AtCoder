using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ABC011C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());

            HashSet<int> NG = new HashSet<int>();
            NG.Add(int.Parse(ReadLine()));
            NG.Add(int.Parse(ReadLine()));
            NG.Add(int.Parse(ReadLine()));

            foreach (int i in NG)
            {
                if (N == i)
                {
                    WriteLine("NO");
                    ReadKey();
                    return;
                }
            }

            int[] dp = new int[N + 1];
            dp[N] = 1;

            for (int n = N; n > 0; n--)
            {
                if (NG.Contains(n) || dp[n] == 0) continue;
                for (int i = 3; i >= 1; i--)
                {
                    if (n - i < 0) continue;
                    if (NG.Contains(n - i)) continue;
                    dp[n - i] = dp[n] + 1;
                    break;
                }
            }

            dp[0]--;
            WriteLine(dp[0] > 0 && dp[0] <= 100 ? "YES" : "NO");
            ReadKey();
        }
    }
}