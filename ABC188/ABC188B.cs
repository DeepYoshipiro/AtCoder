using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC188
{
    class ABC188B
    {
        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());

            var A = ReadLine().Split()
                .Select(n => long.Parse(n)).ToArray();
            var B = ReadLine().Split()
                .Select(n => long.Parse(n)).ToArray();

            long result = 0;
            for (int i = 0; i < N; i++)
            {
                result += A[i] * B[i];
            }

            WriteLine(result == 0 ? "Yes" : "No");
            ReadKey();
        }
    }
}
