using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ARC099C
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int K = init[1];

            int[] A = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            
            int i = Array.IndexOf(A, 1);
            
            int L = (i + (K - 2)) / (K - 1);
            int U = ((N - 1) - i + (K - 2)) / (K - 1);

            WriteLine((L + U).ToString());
            ReadKey();
        }
    }
}