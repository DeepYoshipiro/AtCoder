using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _200pt
{
    class ABC113B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            int[] init = Console.ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int T = init[0];
            int A = init[1];

            int[] H = Console.ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();

            double diff = double.MaxValue;
            int result = -1;
            for (int i = 0; i < N; i++)
            {
                double temperture = T - H[i] * 0.006;
                if (Abs(temperture - A) < diff)
                {
                    diff = Abs(temperture - A);
                    result = i + 1;
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}