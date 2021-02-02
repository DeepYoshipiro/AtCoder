// Solution : BFS
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ABC126D
    {
        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());

            var way = new Dictionary<int, int>[N + 1]
                .Select(v => new Dictionary<int, int>()).ToArray();
            
            for (int i = 1; i < N; i++)
            {
                var input = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                var u = input[0];
                var v = input[1];
                var w = input[2] % 2;

                way[u].Add(v, w);
                way[v].Add(u, w);
            }

            var color = new int[N + 1]
                .Select(v => -1).ToArray();
            color[1] = 0;
            var que = new Queue<int>();
            que.Enqueue(1);

            while (que.Count() > 0)
            {
                var curP = que.Dequeue();

                foreach (KeyValuePair<int, int> nextP in way[curP])
                {
                    if (color[nextP.Key] >= 0) continue;
                    color[nextP.Key] = (color[curP] + nextP.Value) % 2;
                    que.Enqueue(nextP.Key);
                }
            }

            for (int i = 1; i <= N; i++)
            {
                WriteLine(color[i]);
            }
            ReadKey();
        }
    }
}
