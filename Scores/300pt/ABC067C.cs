using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ABC067C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            long[] a = ReadLine().Split(' ')
                .Select(n => long.Parse(n)).ToArray();

            long snukePoint = a.Sum();
            long arigumaPoint = 0;

            long result = long.MaxValue;
            for (int i = 0; i < N - 1; i++)
            {
                snukePoint -= a[i];
                arigumaPoint += a[i];
                if (result > Abs(snukePoint - arigumaPoint))
                    result = Abs(snukePoint - arigumaPoint);
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}