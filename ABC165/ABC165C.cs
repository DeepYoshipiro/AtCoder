using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC165
{
    class ABC165C
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int M = init[1];
            int Q = init[2];

            int[] A = (new int[]{0})
                .Concat(
                    ReadLine().Split().Select(n => int.Parse(n))
                ).ToArray();

            long result = 0;
            for (int q = 1; q <= Q; q++)
            {
                int[] query = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                int a = query[0];
                int b = query[1];
                int c = query[2];
                int d = query[3];

                if (A[b] - A[a] == c)
                {
                    result += d;
                }
            }        

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
