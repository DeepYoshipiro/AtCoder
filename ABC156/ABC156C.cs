using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC156
{
    class ABC156C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            int[] X = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();

            int result = int.MaxValue;
            for (int p = 1; p <= 100; p++)
            {
                int dist = 0;
                for (int i = 0; i < N; i++)
                {
                    dist += (X[i] - p) * (X[i] - p);
                }
                if (dist < result) result = dist;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
