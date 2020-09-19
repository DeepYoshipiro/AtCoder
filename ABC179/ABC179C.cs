using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC179
{
    class ABC179C
    {
        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());

            long result = 0;
            for (int a = 1; a < N; a++)
            {
                var b = N / a;
                if (a * b == N) b--;
                result += (long)b;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
