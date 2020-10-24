using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ABC117D
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => long.Parse(n)).ToArray();
            var N = (int)init[0];
            var K = init[1];

            var A = ReadLine().Split()
                .Select(n => long.Parse(n)).ToArray();

            var maxA = A.Max();
            var maxKA = Max(K, maxA);

            var base2 = new List<long>();
            base2.Add(1);
            while (maxKA >= base2.Last() * 2)
            {
                base2.Add(base2.Last() * 2);
            }
            base2.Reverse();

            var A_base2 = new int[N][]
                .Select(v => new int[base2.Count()]).ToArray();
            var bit = new int[base2.Count()];
            for (int d = 0; d < base2.Count(); d++)
            {
                for (int i = 0; i < N; i++)
                {
                    A_base2[i][d] = (int)(A[i] / base2[d]);
                    if (A_base2[i][d] > 0) 
                    {
                        bit[d]++;
                        A[i] -= base2[d];
                    } 
                }
            }

            long X = 0;
            long result = 0;
            for (int d = 0; d < base2.Count(); d++)
            {
                long num1 = bit[d];
                long num0 = base2.Count() - bit[d];
                if (num0 >= num1 && X + base2[d] <= K)
                {
                    X += base2[d];
                    result += num0 * base2[d];
                }
                else
                {
                    result += num1 * base2[d];
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
