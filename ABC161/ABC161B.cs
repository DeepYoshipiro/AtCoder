using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC161
{
    class ABC161B
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            decimal M = init[1];

            decimal[] A = ReadLine().Split(' ')
                .Select(n => decimal.Parse(n)).ToArray();

            decimal sum = A.Sum();
            int choiceAble = 0;
            for (int i = 0; i < N; i++)
            {
                if (A[i] >= sum / (4 * M))
                {
                    choiceAble++;
                }
            }

            WriteLine(choiceAble >= M ? "Yes" : "No");
            ReadKey();
        }
    }
}
