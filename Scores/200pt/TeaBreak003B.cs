using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace TeaBreak003
{
    class TeaBreak003B
    {
        static void Main(string[] args)
        {
            int[] init = Console.ReadLine().Split(' ')
                        .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int K = init[1];

            int[] A = Console.ReadLine().Split(' ')
                        .Select(n => int.Parse(n)).ToArray();

            int highTone = Max(K, A.Max());
            int lowTone = Min(K, A.Min());
            WriteLine(highTone - lowTone);
            ReadKey();
        }
    }
}