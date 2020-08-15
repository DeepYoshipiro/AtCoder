using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

namespace _300pt
{
    class ABC015C
    {
        static int[][] enquete;
        static int N;
        static int K;

        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
            N = init[0];
            K = init[1];

            enquete = new int[N][];
            for (int i = 0; i < N; i++)
            {
                enquete[i] = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
            }

            bool bugExist = dfs(0, 0);

            WriteLine(bugExist ? "Found" : "Nothing");
            ReadKey();
        }

        static bool dfs(int curQuestionaire, int curResult)
        {
            var result = false;
            for (int j = 0; j < K; j++)
            {
                int newResult = curResult ^ enquete[curQuestionaire][j];
                if (curQuestionaire == N - 1)
                {
                    if (newResult == 0) return true;
                }
                else
                {
                    result |= dfs(curQuestionaire + 1, newResult);
                }
            }

            return result;
        }
    }
}