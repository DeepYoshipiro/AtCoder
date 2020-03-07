using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC142
{
    class ABC142D
    {
        static void Main(string[] args)
        {
            long[] init = ReadLine().Split(' ')
                .Select(n => long.Parse(n)).ToArray();
            long A = init[0];
            long B = init[1];

            //AとBの最大公約数を求める。
            //ユークリッド互除法の実施
            long R = A;

            while (R != 0)
            {
                R = A % B;
                A = B;
                B = R;
            }

            long gcd = A; //最大公約数

            //最大公約数の約数を素因数分解して因数だけ取り出す
            long result = PrimeFactors(gcd).Distinct().ToList().Count + 1;

            WriteLine(result.ToString());
            ReadKey();
        }

        internal static IEnumerable<long> PrimeFactors(long n)
        {
            long i = 2;
            long tmp = n;

            while (i * i <= n)
            {
                if (tmp % i == 0)
                {
                    tmp /= i;
                    yield return i;
                }
                else
                {
                    i++;
                }
            }
            if (tmp != 1) 
            {
                yield return tmp; //最後の素数も返す
            }
        }
    }
}