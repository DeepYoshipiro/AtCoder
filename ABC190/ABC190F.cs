using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC190
{
    class ABC190F
    {
        static void Main(string[] args)
        { 
            var N = int.Parse(ReadLine());
            var A = ReadLine().Split()
                .Select(n => long.Parse(n)).ToArray();

            var cnt = new long[N];
            for (int i = 0; i < N; i++)
            {
                cnt[A[i]]++;
            }

            for (int i = 0; i < N; i++)
            {
                
            }
            WriteLine("Welcome to AtCoder!!");
            ReadKey();
        }
    }
}
