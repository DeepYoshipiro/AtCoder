using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC142
{
    class ABC142C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            int[] A = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int[] order = new int[N];

            for (int i = 0; i < N; i++)
            {
                order[A[i] - 1] = i + 1;
            }

            StringBuilder result = new StringBuilder();
            for (int i = 0; i < N; i++)
            {
                result.Append(order[i].ToString() + " ");
            }

            WriteLine(result.ToString().TrimEnd(' '));
            ReadKey();
        }
    }
}