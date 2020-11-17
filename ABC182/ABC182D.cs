using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC182
{
    class ABC182D
    {
        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());
            var A = ReadLine().Split()
                .Select(n => long.Parse(n)).ToArray();
            
            long result = 0;
            long sum = 0;
            for (int i = 0; i < N; i++)
            {
                sum += A[i];
                if (sum > result) result = sum;
            }

            WriteLine("Welcome to AtCoder!!");
            ReadKey();
        }
    }
}
