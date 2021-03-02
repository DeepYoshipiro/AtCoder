using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC142
{
    class ABC142B
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int K = init[1];

            int[] h = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();

            int result = 0;
            for (int i = 0; i < N; i++){
                if (h[i] >= K) result++;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
