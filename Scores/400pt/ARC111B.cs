using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ARC111B
    {
        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());

            const int MAX_COLOR_NUM = 400000;
            var way = new HashSet<int>[MAX_COLOR_NUM + 1]
                .Select(v => new HashSet<int>()).ToArray();

            int beforeA = 0;
            int beforeB = 0;
            for (int i = 0; i < N; i++)
            {
                var color = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                var A = color[0];
                var B = color[1];

                way[beforeA].Add(A);
                way[beforeA].Add(B);

                way[beforeB].Add(A);
                way[beforeB].Add(B);

                beforeA = A;
                beforeB = B;
            }

            var que = new Queue<int>();
            que.Enqueue(0);

            int usedColor = 0;

            bool[] visited = new bool[MAX_COLOR_NUM + 1];
            bool[] searched = new bool[MAX_COLOR_NUM + 1];

            visited[0] = true;

            while (que.Count > 0)
            {
                var cur = que.Dequeue();
                if (searched[cur]) continue;

                foreach (int next in way[cur])
                {
                    if (visited[next]) continue;
                    visited[next] = true;
                    usedColor++;
                    que.Enqueue(next);
                }
                searched[cur] = true;
            }

            WriteLine(usedColor.ToString());
            ReadKey();
        }
    }
}