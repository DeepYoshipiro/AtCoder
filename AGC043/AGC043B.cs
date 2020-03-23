using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace AGC043
{
    class AGC043B
    {
        const int MOD = 2;

        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            char[] a = ReadLine().ToCharArray();

            Combination comb = new Combination(N - 1);

            long[] mod2 = new long[N];
            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                mod2[i] = comb.Find(N - 1, i);
                mod2[i] %= MOD;
                mod2[i] *= (a[i] - '0') % MOD;
                sum += (int)(mod2[i]);
            }
            sum %= MOD;
            
            WriteLine(sum.ToString());
            ReadKey();
        }        

        class Combination
        {
            const long BIG_MOD = 1000000007;
            long[] fac;
            long[] finv;
            long[] inv;

            // テーブルを作る前処理
            internal Combination(int N)
            {
                // 前処理
                fac = new long[N + 1];
                finv = new long[N + 1];
                inv = new long[N + 1];
    
                fac[0] = fac[1] = 1;
                finv[0] = finv[1] = 1;
                inv[1] = 1;

                for (int i = 2; i <= N; i++)
                {
                    fac[i] = (fac[i - 1] * i) % BIG_MOD;
                    inv[i] = BIG_MOD - inv[BIG_MOD % i] * (BIG_MOD / i) % BIG_MOD;
                    finv[i] = finv[i - 1] * inv[i] % BIG_MOD;
                }
            }

            // 二項係数計算
            internal long Find(int n, int k)
            {
                if (n < k) return 0;
                if (n < 0 || k < 0) return 0;
                return fac[n] * (finv[k] * finv[n - k] % BIG_MOD) % BIG_MOD;
            }
        }
    }
}