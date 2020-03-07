using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ARC073C
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int T = init[1];

            int[] t = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            
            int result = 0;
            for (int i = 0; i < N - 1; i++)
            {
                result += Min(T , t[i + 1] - t[i]);
            }
            result += T;

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
