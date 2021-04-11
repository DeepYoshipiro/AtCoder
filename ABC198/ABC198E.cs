using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC198
{
    class ABC198E
    {
        internal class Vehicle
        {
            internal int Num{get; set;}
            internal bool[] Bad{get; set;}

            internal Vehicle(int pos, int color, int firstColor)
            {
                Num = pos;
                Bad = new bool[color + 1];
                Bad[firstColor] = true;
            }

            internal Vehicle(int pos, bool[] bad)
            {
                Num = pos;
                Bad = bad;
            }
        }
        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());
            var C = new int[]{0}
                .Concat(ReadLine().Split()
                .Select(n => int.Parse(n))).ToArray();

            var edge = new List<int>[N + 1]
                .Select(v => new List<int>()).ToArray();
            for (int i = 0; i < N - 1; i++)
            {
                var e = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                edge[e[0]].Add(e[1]);
                edge[e[1]].Add(e[0]);
            }

            var result = new List<int>();
            var que = new Queue<Vehicle>();
            var colorMax = 100000;
            que.Enqueue(new Vehicle(1, colorMax, C[1]));

            var searched = new bool[N + 1];
            result.Add(1);
            while (que.Count() > 0)
            {
                var cur = que.Dequeue();

                if (searched[cur.Num]) continue;
                searched[cur.Num] = true;

                foreach (int next in edge[cur.Num])
                {
                    var bad = (bool[])cur.Bad.Clone();
                    if (searched[next]) continue;
                    if (!bad[C[next]])
                    {
                        result.Add(next);
                    }
                    bad[C[next]] = true;
                    que.Enqueue(new Vehicle(next, bad));
                }
            }

            result.Sort();
            foreach (int i in result)
            {
                WriteLine(i.ToString());
            }
            ReadKey();
        }
    }
}
