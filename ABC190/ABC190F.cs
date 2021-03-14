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
                .Select(n => int.Parse(n)).ToArray();

            var rsq = new RSQ(N);
            long result = 0;
            for (int i = 0; i < N; i++)
            {
                rsq.Increment(A[i]);
                result += i - rsq.Sum(0, A[i]);
            }

            for (int i = 0; i < N; i++)
            {
                WriteLine(result.ToString());
                result -= A[i];
                result += (N - 1) - A[i];
            }
            ReadKey();
        }

        internal class RSQ
        {
            internal int N;
            internal int n;
            internal long[] sum;

            internal RSQ(int len)
            {
                n = 1;
                while (n < len)
                {
                    n *= 2;
                }
                N = 2 * n - 1;
                
                sum = new long[N];
                for (int i = 0; i < N; i++)
                {
                    sum[i] = 0;
                }
            }

            internal long Sum(int a, int b)
            {
                return Query(a, b, 0, 0, n);
            }

            private long Query(int a, int b, int k, int l, int r)
            {
                long res = 0;
                if (r <= a || b <= l)
                {
                    res = 0;
                }
                else if (a <= l && r <= b)
                {
                    res = sum[k];
                }
                else
                {
                    var vl = Query(a, b, Left(k), l, (l + r) / 2);
                    var vr = Query(a, b, Right(k), (l + r) / 2, r);
                    res = vl + vr;
                }

                return res;
            }

            internal void Increment(int k)
            {
                k = k + n - 1;
                sum[k]++;

                while (k > 0)
                {
                    k = Parent(k);
                    sum[k] = sum[Left(k)] + sum[Right(k)];
                }
            }

            private int Left(int k)
            {
                return 2 * k + 1;
            }

            private int Right(int k)
            {
                return 2 * k + 2;
            }

            private int Parent(int k)
            {
                return (k - 1) / 2;
            }
        }
    }
}
