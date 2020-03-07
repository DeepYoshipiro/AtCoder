using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

namespace _300pt
{
    class ABC107C
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int K = init[1];

            int[] x = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            
            int result = int.MaxValue;
            for (int i = 0; i <= N - K; i++)
            {
                int left = x[i];
                int right = x[i + K - 1];

                int move = right - left + Min(Abs(left), Abs(right));
                if (move < result) result = move;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}