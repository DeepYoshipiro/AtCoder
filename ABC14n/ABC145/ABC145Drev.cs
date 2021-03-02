using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC145
{
    class ABC145Drev
    {
        const int MAX = 1000000;
        const int MOD = 1000000007;

        static long[] fac, finv, inv;

        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                    .Select(n => int.Parse(n)).ToArray();
            int X = init[0];
            int Y = init[1];

            if ((X + Y) % 3 != 0)
            {
                WriteLine("0");
                ReadKey();
                return;
            }

            int trialCnt = (X + Y) / 3;
            X -= trialCnt;
            Y -= trialCnt;

            if (X < 0 || Y < 0)
            {
                WriteLine("0");
                ReadKey();
                return;
            }

            COMinit();
            double result = 0;
            result += COM(trialCnt, Min(X, Y));

            WriteLine(result.ToString());
            ReadKey();
        }

        // テーブルを作る前処理
        static void COMinit() {
            fac = new long[MAX];
            finv = new long[MAX];
            inv = new long[MAX];

            fac[0] = fac[1] = 1;
            finv[0] = finv[1] = 1;
            inv[1] = 1;
            for (int i = 2; i < MAX; i++){
                fac[i] = fac[i - 1] * i % MOD;
                inv[i] = MOD - inv[MOD%i] * (MOD / i) % MOD;
                finv[i] = finv[i - 1] * inv[i] % MOD;
            }
        }

        // 二項係数計算
        static long COM(int n, int k){
            if (n < k) return 0;
            if (n < 0 || k < 0) return 0;
            return fac[n] * (finv[k] * finv[n - k] % MOD) % MOD;
        }
    }
}