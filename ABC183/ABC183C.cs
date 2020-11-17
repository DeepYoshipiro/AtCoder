using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC183
{
    class ABC183C
    {
        static int N;
        static int K;

        static int[][] T;

        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            N = init[0];
            K = init[1];

            T = new int[N][];
            for (int i = 0; i < N; i++)
            {
                T[i] = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
            }

            var visited = new bool[N];
            visited[0] = true;
            var result = DFS(0, 0, 1, visited);

            WriteLine(result.ToString());
            ReadKey();
        }

        static int DFS(int time, int cur, int visitedCityCnt, bool[] visited)
        {
            if (visitedCityCnt > N)
            {
                return time == K ? 1 : 0;
            }
            int result = 0;
            
            var vClone = (bool[])visited.Clone();
            if (visitedCityCnt == N)
            {
                result += DFS(time + T[cur][0], 0, N + 1, vClone);
                return result;
            }

            for (int i = 0; i < N; i++)
            {
                if (!vClone[i])
                {
                    vClone[i] = true;
                    result += DFS(time + T[cur][i], i, visitedCityCnt + 1, vClone);
                    vClone[i] = false;
                }
            }
            return result;
        }
    }
}
