using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _200pt
{
    class ABC051B
    {
        static void Main(string[] args)
        {
            int[] init = Console.ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int K = init[0];
            int S = init[1];

            int result = 0;
            for (int X = 0; X <= K; X++)
            {
                for (int Y = 0; Y <= K; Y++)
                {
                    if (S - (X + Y) >= 0 && S - (X + Y) <= K)
                    result++;
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}