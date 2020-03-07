using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ABC054C
    {
        static List<int>[] route;
        static int N;
        static int result = 0;

        static void Main(string[] args)
        {
            //input
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            N = init[0];
            int M = init[1];

            route = new List<int>[N + 1];
            for (int i = 1; i <= N; i++) {
                route[i] = new List<int>();
            }

            for (int i = 0; i < M; i++) {
                int[] p = ReadLine().Split(' ')
                    .Select(n => int.Parse(n)).ToArray();

                route[p[0]].Add(p[1]);
                route[p[1]].Add(p[0]);
            }

            //calculate
            bool[] visited = new bool[N + 1];
            for (int i = 1; i <= N; i++) {
                visited[i] = false;
            }

            FindWay(1, 0, visited);

            //output;
            WriteLine(result.ToString());
            ReadKey();
        }

        private static void FindWay
            (int pos, int reached, bool[] prevVisited)
        {
            bool[] curVisited = (bool[])prevVisited.Clone();
            curVisited[pos] = true;

            reached++;
            if (reached == N) {
                result++;
                return;
            }

            foreach (int i in route[pos]) {
                if (!prevVisited[i]) FindWay(i, reached, curVisited);
            }
        }
    }
}
