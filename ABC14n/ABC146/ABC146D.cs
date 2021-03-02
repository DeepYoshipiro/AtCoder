using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC146
{
    class ABC146D
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            int[] edge = new int[N + 1];
            //List<int>[] way = new List<int>[N + 1];
            int[] from = new int[N + 1];
            int[] to = new int[N + 1];

            for (int i = 0; i < N - 1; i++)
            {
                int[] init = ReadLine().Split(' ')
                    .Select(n => int.Parse(n)).ToArray();
                edge[init[0]]++;
                edge[init[1]]++;
                //way[init[0]].Add(init[1]);
                //way[init[1]].Add(init[0]);

                from[i] = init[0];
                to[i] = init[1];
            }

            int K = 0;
            for (int i = 1; i <= N; i++)
            {
                if (edge[i] > K) K = edge[i];
            }
            WriteLine(K.ToString());

            int[] minNum = new int[N + 1];
            for (int i = 0; i < N - 1; i++)
            {
                int Col = Max(++minNum[from[i]], ++minNum[to[i]]);
                WriteLine(Col.ToString());
            }

            ReadKey();
        }
    }
}