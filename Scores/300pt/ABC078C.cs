using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ABC078C
    {
        static void Main(string[] args)
        {
            int[] input = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int N = input[0];
            int M = input[1];

            int S = 1900 * M + 100 * (N - M);   //1回あたりの提出時間(ms)

            int X = (int)Pow(2, M) * S;

            WriteLine(X.ToString());
            ReadKey();
        }
    }
}
