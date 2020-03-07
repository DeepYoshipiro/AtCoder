using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ABC112D
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int M = init[1];

            int result = GetDiv(M, M / N);

            WriteLine(result.ToString());
            ReadKey();
        }

        static int GetDiv(int n, int upper)
        {
            List<int> d = new List<int>();
            for (int i = 1; i <= Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    if (i <= upper) d.Add(i);
                    if (n / i <= upper) d.Add(n / i);
                }
            }
            d.Sort();

            return d.Last();
        }
    }
}