using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC200
{
    class ABC200C
    {
        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());

            var R = new long[200];
            
            var A = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            for (int i = 0; i < N; i++)
            {
                R[A[i] % 200]++;
            }

            long result = 0;
            for (int j = 0; j < 200; j++)
            {
                if (R[j] <= 1) continue;
                result += (R[j] * (R[j] - 1)) / 2;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
