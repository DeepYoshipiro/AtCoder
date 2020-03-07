using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

using System.Numerics;

namespace ABC156
{
    class ABC156D
    {
        static void Main(string[] args)
        {
            long[] unlike = ReadLine().Split()
                .Select(m => long.Parse(m)).ToArray();
            long n = unlike[0];

            long mod = (long)Pow(10, 9) + 7;
            //n = n % (mod - 1);
            long result = myPow(2, n, mod);
            //Biglongeger result = (Biglongeger)Pow(2, n);
            result--;

            CombinationPermutation comb = new CombinationPermutation(n);
            result -= comb.nCr(n, unlike[1]);
            if (result < 0) result += mod;

            result -= comb.nCr(n, unlike[2]);
            if (result < 0) result += mod;
/*             for (long j = 1; j <= 2; j++)
            {
                long Comb = 1;

                for (long k = 0; k < unlike[j]; k++)
                {
                    Comb *= (n - k);
                }

                for (long k = 1; k <= unlike[j]; k++)
                {
                    Comb /= k;
                }
                Comb %= mod;
                result -= (long)Comb;
            }
 */
            WriteLine(result.ToString());
            ReadKey();
        }

        static long myPow(long x, long n, long m){
            if(n == 0)
                return 1;
            if(n % 2 == 0)
                return myPow(x * x % m, n / 2, m);
            else
                return x * myPow(x, n - 1, m) % m;
        }

        class CombinationPermutation
        {
            private readonly long[] fac;
 
            // (mod Mの)階乗テーブル作成する
            public CombinationPermutation(long n)
            {
                fac = new long[n + 1];
                fac[0] = 1;
                for (long i = 1; i <= n; ++i)
                {
                    fac[i] = modMCalc.Mul(fac[i - 1], i);
                }
            }
 
            // 階乗求める
            public long Factorial(long n)
            {
                return fac[n];
            }
 
            // nPr
            public long nPr(long n, long r)
            {
                if (n < r)
                {
                    return 0;
                }
 
                if (n == r)
                {
                    return 1;
                }
 
                long result = Factorial(n);
                result = modMCalc.Div(result, Factorial(n - r));
 
                return result;
            }
 
            // nCr
            public long nCr(long n, long r)
            {
                return modMCalc.Div(nPr(n, r), Factorial(r));
            }
        }

        class modMCalc
        {
            private const long M = 1000000007;       // 素数(long範囲)
 
            // 乗算結果 % Mを求める
            static public long Mul(long a, long b)
            {
                return (long)(Math.BigMul((int)a, (int)b) % M);
            }
 
            // 冪乗(mod M)
            static public long Pow(long a, long m)
            {
                if (0 == m)
                {
                    return 1;
                }
                if (1 == m)
                {
                    return a;
                }
 
                long result = 1;
                long param = a;
                for (; m > 0; m >>= 1)
                {
                    if ((m & 0x01) == 1)
                    {
                        result = Mul(result, param);
                    }
 
                    param = Mul(param, param);
                }
 
                return result;
            }
            // 除算(mod M)
            static public long Div(long a, long b)
            {
                return Mul(a, Pow(b, M - 2));
            }
        }
    }
}
