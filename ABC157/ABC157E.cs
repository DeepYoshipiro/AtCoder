using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC157
{
    class ABC157E
    {
        static void Main(string[] args)
        { 
            var N = int.Parse(ReadLine());
            var S = (new char[]{' '}).Concat(ReadLine()).ToArray();
            var Q = int.Parse(ReadLine());

            var rsq = new RSQ(N + 1);
            for (int i = 1; i <= N; i++)
            {
                int kindS = 1 << (S[i] - 'a');
                rsq.UpDate(i, kindS);
            }

            var result = new List<int>();
            for (int j = 0; j < Q; j++)
            {
                var que = ReadLine().Split().ToArray();
                switch (int.Parse(que[0]))
                {
                    case 1:
                        int changeS = 1 << (char.Parse(que[2]) - 'a');
                        rsq.UpDate(int.Parse(que[1]), changeS);
                        break;
                    case 2:
                        var bitSeq = rsq.Sum(int.Parse(que[1]), int.Parse(que[2]) + 1);
                        result.Add(bitCnt(bitSeq));
                        break;
                }
            }

            foreach (int res in result)
            {
                WriteLine(res.ToString());
            }
            ReadKey();
        }

        static internal int bitCnt(int bitSeq)
        {
            int result = 0;
            for (int i = 0; i <= 'z' - 'a'; i++)
            {
                result += bitSeq >> i & 1;
            }

            return result;
        }

        internal class RSQ
        {
            internal int N;
            internal int n;
            internal int[] sum;

            internal RSQ(int len)
            {
                n = 1;
                while (n < len)
                {
                    n *= 2;
                }
                N = 2 * n;
                
                sum = new int[N];
            }

            internal int Sum(int a, int b)
            {
                return Query(a, b, 0, 0, n);
            }

            private int Query(int a, int b, int k, int l, int r)
            {
                int res = 0;
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
                    res = vl | vr;
                }

                return res;
            }

            internal void UpDate(int k, int x)
            {
                k = k + n - 1;
                sum[k] = x;

                while (k > 0)
                {
                    k = Parent(k);
                    sum[k] = sum[Left(k)] | sum[Right(k)];
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
