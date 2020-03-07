using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ABC122C
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int Q = init[1];
            char[] S = (new char[1]{' '})
                .Concat(ReadLine().ToCharArray()).ToArray();

            int[] AC = new int[N + 1];
            int sum = 0;
            for (int i = 1; i < N; i++)
            {
                AC[i] = sum;
                if (S[i].Equals('A') && S[i + 1].Equals('C'))
                {
                    sum++;
                    AC[i + 1] = sum;
                    i++;
                }
            }
            AC[N] = sum;

            int[] l = new int[Q];
            int[] r = new int[Q];
            for (int j = 0; j < Q; j++)
            {
                int[] queue = ReadLine().Split(' ')
                    .Select(n => int.Parse(n)).ToArray();
                l[j] = queue[0];
                r[j] = queue[1];
            }

            for (int k = 0; k < Q; k++)
            {
                WriteLine(AC[r[k]] - AC[l[k]]);
            }
            ReadKey();
        }
    }
}