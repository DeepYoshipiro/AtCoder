using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ABC097D
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int M = init[1];

            int[] p = (new int[]{0})
                .Concat(ReadLine().Split()
                        .Select(n => int.Parse(n))
                        ).ToArray();

            List<int>[] node = new List<int>[N + 1];
            for (int i = 0; i <= N; i++)
            {
                node[i] = new List<int>();
            }

            for (int j = 0; j < M; j++)
            {
                int[] path = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
                int x = path[0];
                int y = path[1];

                node[x].Add(y);
                node[y].Add(x);
            }

            int grpCnt = 0;
            int[] grp = new int[N + 1];
            for (int i = 1; i <= N; i++)
            {
                bool newArrive = false;
                Queue<int> que = new Queue<int>();
                que.Enqueue(i);
                while (que.Count > 0)
                {
                    int from = que.Dequeue();
                    if (grp[from] > 0) continue;
                    if (!newArrive)
                    {   
                        grpCnt++;
                        newArrive = true;
                    }
                    grp[from] = grpCnt;
                    foreach (int to in node[from])
                    {
                        if (grp[to] > 0) continue;
                        que.Enqueue(to);
                    }
                }
            }

            List<int>[] original = new List<int>[grpCnt + 1];
            List<int>[] order = new List<int>[grpCnt + 1];
            for (int i = 1; i <= grpCnt; i++)
            {
                original[i] = new List<int>();
                order[i] = new List<int>();
            }

            for (int i = 1; i <= N; i++)
            {
                original[grp[i]].Add(p[i]);
                order[grp[i]].Add(i);
            }

            int result = 0;
            for (int i = 1; i <= grpCnt; i++)
            {
                result += original[i].Intersect(order[i]).Count();
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}

