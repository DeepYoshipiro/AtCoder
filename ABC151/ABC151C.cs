using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC151
{
    class ABC151C
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int M = init[1];

            int[] AC = new int[N];
            long[] WA = new long[N];

            for (int i = 0; i < M; i++)
            {
                string[] info = ReadLine().Split().ToArray();

                int p = int.Parse(info[0]) - 1;
                string S = info[1];
                if (S.Equals("AC"))
                {
                    AC[p] = 1;
                }
                else if (AC[p] == 0)   //WA
                {
                    WA[p]++;
                }
            }

            for (int i = 0; i < N; i++)
            {
                if (AC[i] == 0) WA[i] = 0;
            }

            Write(AC.Sum().ToString() + " ");
            WriteLine(WA.Sum().ToString());
            ReadKey();
        }
    }
}
