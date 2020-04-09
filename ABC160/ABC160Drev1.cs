using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC160
{
    class ABC160Drev1
    {
        static void Main(string[] args)
        {
            int MaxDist = 10000;

            int[] init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int X = init[1];
            int Y = init[2];

            int[][] dist = new int[N + 1][];
            for (int i = 1; i <= N; i++)
            {
                dist[i] = Enumerable
                    .Repeat(MaxDist, N + 1).ToArray();

                Queue<int> searchQue = new Queue<int>();
                bool[] arrived = new bool[N + 1];
                dist[i][i] = 0;
                searchQue.Enqueue(i);

                while (searchQue.Count > 0)
                {
                    int cur = searchQue.Dequeue();
                    if (cur > 1)
                        Mark(cur, cur - 1, dist[i], arrived, searchQue);

                    if (cur < N)
                        Mark(cur, cur + 1, dist[i], arrived, searchQue);
                    
                    if (cur == X)
                        Mark(cur, Y, dist[i], arrived, searchQue);

                    if (cur == Y)
                        Mark(cur, X, dist[i], arrived, searchQue);
                }
            }

            int[] result = new int[N + 1];
            for (int i = 1; i < N; i++)
            {
                for (int j = i + 1; j <= N; j++)
                {
                    result[dist[i][j]]++;
                }
            }

            for (int k = 1; k < N; k++)
            {
                WriteLine(result[k].ToString());
            }
            ReadKey();
        }

        static void Mark(int curStation, int nextStation
                        , int[] dist, bool[] arrived
                        , Queue<int> que)
        {
            int j = nextStation;
            int cur = curStation;
            dist[j] = Min(dist[j], dist[cur] + 1);
            if (!arrived[j])
            {
                que.Enqueue(j);
                arrived[j] = true;
            }
        } 
    }
}
