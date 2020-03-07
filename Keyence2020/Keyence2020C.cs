using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace Keyence2020
{
    class Keyence2020C
    {
        static void Main(string[] args)
        {
            long[] init = ReadLine().Split(' ')
                .Select(n => long.Parse(n)).ToArray();
            long N = init[0];
            long K = init[1];
            long S = init[2];

            long[] result = new long[N];
            if (N == K)
            {
                for (int i = 0; i < N; i++)
                {
                    Write(S.ToString() + " ");
                }
                WriteLine();
                ReadKey();
                return;
            }

            result[0] = 1;
            if (result[0] == S) K--;
            for (int i = 1; i < N; i++)
            {
                if (K > 0)
                {
                    result[i] = S - result[i - 1];
                    if (result[i] == 0) result[i] = 1;
                    K--;
                }
                else
                {
                    result[i] = (int)Pow(10, 9);
                    while (result[i] == S || result[i - 1] + result[i] == S) result[i]--;
                }
            }
 
            for (int i = 0; i < N; i++)
            {
                Write(result[i].ToString() + " ");
            }
            WriteLine();
            ReadKey();
        }
    }
}