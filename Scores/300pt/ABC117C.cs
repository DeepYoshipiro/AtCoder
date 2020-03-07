using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ABC117C
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int M = init[1];

            int[] X = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).OrderBy(n => n).ToArray();

            if (N >= M)
            {
                WriteLine("0");
                ReadKey();
                return;
            }

            List<int> diff = new List<int>();
            for (int i = 0; i < M - 1; i++)
            {
                diff.Add(X[i + 1] - X[i]);
            }
            diff.Sort();
            diff.Reverse();

            for (int i = 0; i < N - 1; i++)
            {
                diff.RemoveAt(0);
            }

            int result = diff.Sum();
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}