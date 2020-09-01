using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ABC115D
    {
        static long[] BurgerLayerCnt;
        static long[] PattyCnt;

        static void Main(string[] args)
        {
            var init = ReadLine().Split(' ')
                .Select(n => long.Parse(n)).ToArray();
            var N = (int)init[0];
            var X = init[1];

            BurgerLayerCnt = new long[N + 1];
            PattyCnt = new long[N + 1];

            BurgerLayerCnt[0] = 1;
            PattyCnt[0] = 1;

            for (int i = 1; i <= N; i++)
            {
                BurgerLayerCnt[i] = 2 * BurgerLayerCnt[i - 1] + 3;
                PattyCnt[i] = 2 * PattyCnt[i - 1] + 1;
            }

            WriteLine(AtePatty(N, X).ToString());
            ReadKey();
        }

        static long AtePatty(int N, long X)
        {
            if (N == 0) return X;

            if (X == 1) return 0;
            else if (X <= BurgerLayerCnt[N - 1] + 1)
                return AtePatty(N - 1, X - 1);
            else if (X == BurgerLayerCnt[N - 1] + 2)
                return PattyCnt[N - 1] + 1;
            else if (X < BurgerLayerCnt[N])
                return PattyCnt[N - 1] + 1
                    + AtePatty(N - 1, X - (BurgerLayerCnt[N - 1] + 2));
            else return PattyCnt[N];
        }
    }
}

