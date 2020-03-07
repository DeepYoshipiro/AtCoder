using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace Keyence2020
{
    class Keyence2020B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());

            long[] min = new long[N];
            long[] max = new long[N];
            for (int i = 0; i < N; i++)
            {
                long[] info = ReadLine().Split(' ')
                    .Select(n => long.Parse(n)).ToArray();
                long X = info[0];
                long L = info[1];

                min[i] = X - L;
                max[i] = X + L - 1;
            }
            int result = N;
            Array.Sort(min);
            Array.Sort(max);
            for (int i = 0; i < N - 1; i++)
            {
                if (min[N - i - 1] <= max[i]) result--;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}