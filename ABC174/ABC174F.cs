using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC174
{
    class ABC174F
    {
        static void Main(string[] args)
        {
            // var N = int.Parse(ReadLine());
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var N = init[0];
            var Q = init[1];

            var C = (new int[]{0})
                .Concat(ReadLine().Split().Select(n => int.Parse(n)))
                .ToArray();

            var rsq = new RSQ(N + 1);
            for (int i = 1; i <= N; i++)
            {
                // rsq.Update(i, C[i]);
            }

            // var N = long.Parse(ReadLine());
            // var init = ReadLine().Split()
            //     .Select(n => long.Parse(n)).ToArray();
            // var N = init[0];
            // var M = init[1];

            // var S = ReadLine().ToCharArray();
            // var S = ReadLine();
            // var S = ReadLine().ToArray();

            WriteLine("Welcome to AtCoder!!");
            ReadKey();
        }

        internal class RSQ
        {
            private int N;
            private int n;
            private int[] sum;

            internal RSQ(int len)
            {
                n = 1;
                while (n < len)
                {
                    n *= 2;
                }
                N = 2 * n - 1;

                sum = new int[N];
            }

            // internal Update(int idx, int val)
            // {
            //     idx += n - 1;
            //     sum[idx] = val

            //     while (idx > 0)
            //     {
                    
            //     }
            // }
        }
    }
}
