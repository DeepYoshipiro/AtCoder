using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ABC097Drev1
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

            int[] grpIdx = new int[N + 1];
            int[] grpIdxTable = new int[N + 1];
            for (int i = 1; i <= N; i++)
            {
                grpIdx[i] = int.MaxValue;
                grpIdxTable[i] = i;
            }
            int usedGrpIdx = 0;

            for (int j = 0; j < M; j++)
            {
                int[] path = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                int x = path[0];
                int y = path[1];

                int grp = Min(grpIdx[x], grpIdx[y]);
                if (grp > N)
                {
                    usedGrpIdx++;
                    grpIdx[x] = usedGrpIdx;
                    grpIdx[y] = usedGrpIdx;
                }
                else
                {
                    int oldGrp = Max(grpIdx[x], grpIdx[y]);
                    if (oldGrp <= N)
                    {
                        grpIdxTable[oldGrp] = grp;
                    }

                    grpIdx[x] = grp;
                    grpIdx[y] = grp;
                }
            }

            for (int i = usedGrpIdx; i >= 1; i--)
            {
                int from = i;
                int to = grpIdxTable[i];
                while (from != to)
                {
                    to = grpIdxTable[from];
                    from = grpIdxTable[to];
                }
                grpIdxTable[i] = to;
            }

            for (int i = 1; i <= N; i++)
            {
                if (grpIdx[i] > N)
                {
                    usedGrpIdx++;
                    grpIdx[i] = usedGrpIdx;
                }
                else
                {
                    grpIdx[i] = grpIdxTable[grpIdx[i]];
                }
            }

            List<int>[] original = new List<int>[usedGrpIdx + 1];
            List<int>[] order = new List<int>[usedGrpIdx + 1];
            for (int i = 1; i <= usedGrpIdx; i++)
            {
                original[i] = new List<int>();
                order[i] = new List<int>();
            }

            for (int i = 1; i <= N; i++)
            {
                original[grpIdx[i]].Add(p[i]);
                order[grpIdx[i]].Add(i);
            }

            int result = 0;
            for (int i = 1; i <= usedGrpIdx; i++)
            {
                result += original[i].Intersect(order[i]).Count();
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}