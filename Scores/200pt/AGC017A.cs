using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _200pt
{
    class AGC017A
    {
        static void Main(string[] args)
        {
            int[] init = Console.ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int P = init[1];

            int[] count = new int[2];
            count[0] = Console.ReadLine().Split(' ')
                .Select(n => int.Parse(n))
                .Count(n => n % 2 == 0);
            count[1] = N - count[0];

            long result = (long)(Pow(2, count[0]) * (Pow(2, count[1] - 1))); 
            if (P == 1 && count[1] == 0) result = 0;
            if (P == 0 && count[0] == 0 && N == 1) result = 0;

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}