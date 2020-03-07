using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

namespace _300pt
{
    class ABC113C
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int M = init[1];

            int[] P = new int[M];
            int[] Y = new int[M];

            List<int>[] madeCity = new List<int>[N + 1];
            for (int i = 0; i <= N; i++)
            {
                madeCity[i] = new List<int>();
            }

            for (int j = 0; j < M; j++)
            {
                int[] info = ReadLine().Split(' ')
                    .Select(n => int.Parse(n)).ToArray();
                P[j] = info[0];
                Y[j] = info[1];

                madeCity[P[j]].Add(Y[j]);
            }

            for (int i = 0; i <= N; i++)
            {
                if (madeCity[i].Count >= 2)
                {
                    madeCity[i].Sort();
                }
            }

            for (int j = 0; j < M; j++)
            {
                int curP = P[j];
                string outputP = curP.ToString().PadLeft(6, '0');
                string order = "";
                for (int k = 0; k < madeCity[curP].Count(); k++)
                {
                    if (madeCity[curP][k] == Y[j])
                    {
                        order = (k + 1).ToString().PadLeft(6, '0');
                        break;
                    }
                }
                WriteLine(outputP + order);
            }

            ReadKey();
        }
    }
}
