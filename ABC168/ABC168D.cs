using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC168
{
    class ABC168D
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var N = init[0];
            var M = init[1];

            var Way = new List<int>[N + 1];
            var visited = new int[N + 1];
            for (int i = 1; i <= N; i++)
            {
                Way[i] = new List<int>();
                visited[i] = int.MaxValue;
            }

            for (int m = 0; m < M; m++)
            {
                var to = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                Way[to[0]].Add(to[1]);
                Way[to[1]].Add(to[0]);
            }

            visited[1] = 0;
            int visitedRoom = 1;
            var nextVisit = new Queue<int>();
            nextVisit.Enqueue(1);
            while (nextVisit.Count > 0)
            {
                int cur = nextVisit.Dequeue();

                foreach (int next in Way[cur])
                {
                    if (visited[next] > 2 * N)
                    {
                        visited[next] = cur;
                        visitedRoom++;
                        nextVisit.Enqueue(next);
                    }
                }
            }

            if (visitedRoom == N)
            {
                WriteLine("Yes");
                for (int i = 2; i <= N; i++)
                {
                    WriteLine(visited[i].ToString());
                }
            }
            else
            {
                WriteLine("No");
            }
            ReadKey();
        }
    }
}
