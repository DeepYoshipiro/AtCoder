using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC178
{
    class ABC178D
    {
        static void Main(string[] args)
        {
            var S = int.Parse(ReadLine());
            int N = 0;
            long result = 0;
            var dm = new DiscreteMath();

            long MOD = (long)Pow(10, 9) + 7;
            while (S >= 3)
            {
                N++;
                S -= 3;
                result += dm.Combination(S + 1, MOD)[N - 1];
                result %= MOD;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }

    class DiscreteMath
    {
        internal long GCD(long A, long B)
        {
            long R = A;

            while (R > 0)
            {
                R = A % B;
                A = B;
                B = R;
            }
            return A;
        }

        internal long LCM(long A, long B)
        {
            long d = GCD(A, B);
            return A / d * B;
        }

        internal IEnumerable<long> Divisor(long N)
        {
            for (int i = 1; i * i <= N; i++)
            {
                if (N % i == 0)
                {
                    yield return i;
                    if (i * i != N) yield return N / i;
                }
            }
            yield break;
        }

        internal IEnumerable<long> PrimeFactorize(long N)
        {
            long firstN = N;
            long div = 2;
            while (N >= 1 && div * div < firstN)
            {
                if (N % div == 0)
                {
                    N /= div;
                    yield return div;
                }
                else
                {
                    div++;
                }                    
            }
            if (N > 1)
            {
                yield return N;
            }
        }

        internal long extGCD(long A, long B, out long X, out long Y)
        {
            var curR = new List<long>();
            var curX = new List<long>();
            var curY = new List<long>();
            curR.Add(A);
            curX.Add(1);
            curY.Add(0);
            
            curR.Add(B);
            curX.Add(0);
            curY.Add(1);

            while (curR[curR.Count() - 2] % curR[curR.Count - 1] != 0)
            {
                var idxA = curR.Count() - 2;
                var idxB = curR.Count() - 1;

                var curA = curR[idxA];
                var curB = curR[idxB];

                curR.Add(curA % curB);
                var Q = curA / curB;

                curX.Add(curX[idxA] - Q * curX[idxB]);
                curY.Add(curY[idxA] - Q * curY[idxB]);
            }

            X = curX.Last();
            Y = curY.Last();
            return curR.Last();
        }

        internal IEnumerable<long> Sieve(long N)
        {
            var prime = new bool[N + 1];
            for (long i = 2; i <= N; i++)
            {
                prime[i] = true;
            }

            for (long i = 2; i * i <= N; i++)
            {
                if (!prime[i]) continue;
                for (long j = 2 * i; j <= N; j += i)
                {
                    prime[j] = false;
                }
            }

            for (long i = 2; i <= N; i++)
            {
                if (prime[i]) yield return i;
            }
            yield break;
        }

        internal long[] Combination(long N, long MOD)
        {
            var inverse = new long[N + 1];
            inverse[0] = 0;
            for (long i = 1; i <= N; i++)
            {
                inverse[i] = Inverse(i, MOD);
            }

            var comb = new long[N + 1];
            comb[0] = 1;
            for (long i = 1; i <= N; i++)
            {
                comb[i] = (comb[i - 1] * (N + 1 - i)) % MOD;
                comb[i] *= inverse[i];
                comb[i] %= MOD;
                if (comb[i] < 0) comb[i] += MOD;
            }
            return comb;
        }

        private long Inverse(long A, long MOD)
        {
            long X = 0;
            long Y = 0;
            extGCD(A, MOD, out X, out Y);
            if (X < 0) X += MOD;
            return X;
        }

    }}
