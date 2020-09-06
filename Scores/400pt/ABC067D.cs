using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ABC067D
    {
        static List<int>[] edge;

        const int Fennec = 1;
        const int Snuke = 2;

        static int[] color;

        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());

            edge = new List<int>[N + 1];

            var distFromF = new int[N + 1];
            var distFromS = new int[N + 1];

            for (int i = 1; i <= N; i++)
            {
                edge[i] = new List<int>();

                distFromF[i] = -1;
                distFromS[i] = -1;
            }

            for (int j = 1; j < N; j++)
            {
                var way = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                edge[way[0]].Add(way[1]);
                edge[way[1]].Add(way[0]);
            }

            int beginF = 1;
            int beginS = N;

            distFromF[beginF] = 0;
            distFromS[beginS] = 0;

            MeasureDist(beginF, distFromF);
            MeasureDist(beginS, distFromS);

            var dist = distFromS[beginF];

            color = new int[N + 1];

            var expandF = new Queue<int>();
            var expandS = new Queue<int>();

            for (int i = 1; i <= N; i++)
            {
                if (distFromF[i] + distFromS[i] == dist)
                {
                    if (distFromF[i] <= distFromS[i])
                    {
                        color[i] = Fennec;
                        expandF.Enqueue(i);
                    }
                    else
                    {
                        color[i] = Snuke;
                        expandS.Enqueue(i);
                    }
                }
            }

            ExpandArea(Fennec, expandF);
            ExpandArea(Snuke, expandS);

            int FennecAhead = 0;
            for (int i = 1; i <= N; i++)
            {
                switch (color[i])
                {
                    case Fennec:
                        FennecAhead++;
                        break;
                    case Snuke:
                        FennecAhead--;
                        break;
                }
            }

            if (FennecAhead > 0)
                WriteLine("Fennec");
            else
                WriteLine("Snuke");

            ReadKey();
        }

        static void MeasureDist(int beginPos, int[] distFrom)
        {
            var que = new Queue<int>();
            que.Enqueue(beginPos);

            while (que.Count() > 0)
            {
                int curPos = que.Dequeue();

                foreach (int nextPos in edge[curPos])
                {
                    if (distFrom[nextPos] >= 0) continue;
                    distFrom[nextPos] = distFrom[curPos] + 1;
                    que.Enqueue(nextPos);
                }
            }
        }

        static void ExpandArea(int player, Queue<int> basePos)
        {
            while (basePos.Count() > 0)
            {
                int curPos = basePos.Dequeue();

                foreach (int nextPos in edge[curPos])
                {
                    if (color[nextPos] > 0) continue;
                    color[nextPos] = player;
                    basePos.Enqueue(nextPos);
                }
            }

        }
    }
}
