using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace TDPC
{
    class TDPC_A
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            int[] p = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            
            int perfectScore = p.Sum();
            int[][] dp = new int[N + 1][];
			dp[0] = new int[perfectScore + 1];
            dp[0][0] = 1;
            HashSet<int> score = new HashSet<int>();
            score.Add(0);

            for (int i = 0; i < N; i++)
            {
              	dp[i + 1] = new int[perfectScore + 1];
                HashSet<int> new_score = new HashSet<int>();
                foreach (int s in score)
                {
                    //この問題を得点しない場合
                    chmax(ref dp[i + 1][s], dp[i][s]);

                    //この問題を得点する場合
                    chmax(ref dp[i + 1][s + p[i]], 1);
                    new_score.Add(s + p[i]);
                }
                score.UnionWith(new_score);
            }

            int result = score.Count();
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