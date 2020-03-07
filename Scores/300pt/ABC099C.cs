using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ABC099C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            int[] dp = new int[200001];
            for (int i = 1; i < dp.Length; i++) dp[i] = N + 1;
            dp[0] = 0;

            List<int> withdrawAbleAtOnce = new List<int>();
            withdrawAbleAtOnce.Add(1);
            for (int i = 0; i <= (int) Log(N + 1, 6); i++)
            {
                withdrawAbleAtOnce.Add((int) Pow(6, i));
            }

            for (int i = 0; i <= (int) Log(N + 1, 9); i++)
            {
                withdrawAbleAtOnce.Add((int) Pow(9, i));
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < withdrawAbleAtOnce.Count; j++)
                {
                    int y = withdrawAbleAtOnce[j];
                    chmin(ref dp[i + y], dp[i] + 1);
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