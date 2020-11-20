using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC171
{
    class ABC171E
    {
        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());
            var A = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();

            var xorSum = 0;
            for (int i = 0; i < N; i++)
            {
                xorSum ^= A[i];
            }

            var result = new StringBuilder();
            for (int i = 0; i < N; i++)
            {
                result.Append((xorSum ^ A[i]).ToString() + " ");
            }
            WriteLine(result.ToString().TrimEnd());
            ReadKey();
        }
    }
}
