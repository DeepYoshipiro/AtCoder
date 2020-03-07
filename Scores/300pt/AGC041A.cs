using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class AGC041A
    {
        static void Main(string[] args)
        {
            long[] init = ReadLine().Split(' ')
                .Select(n => long.Parse(n)).ToArray();
            long N = init[0];
            long A = init[1];
            long B = init[2];

            if ((B - A) % 2 == 0)
            {
                WriteLine((B - A) / 2);
                ReadKey();
                return;
            }
            
            long result;
            if (A - 1 < N - B)
            {
                long win = A + 1;
                result = A + ((B - win) + 1) / 2;
            }
            else
            {
                long lose = N - B + 1;
                result = lose + (N - (A + lose)) / 2; 
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}