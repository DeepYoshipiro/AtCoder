using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC154
{
    class ABC154Erev2
    {
        static void Main(string[] args)
        {
            char[] input = ReadLine().ToCharArray();
            int digit = input.Length;

            int[] N = new int[digit + 1];
            for (int i = 0; i < digit; i++)
            {
                N[i + 1] = input[i] - '0';
            }

            int K = int.Parse(ReadLine());  // not 0

            // dpCases[i][k][f]
            //  i: 左からiけた目までに、（1-indexed）
            //  k: 0じゃない数字がk個でてきており、
            //  f: (fall) ∈{0, 1}として、
            //   そこまでの桁が左からi桁目までと1、そうでなければ0
            // としたときの、満たす数字の並びの場合の数を表す。
            long[][][] dpCases = new long[digit + 1][][];
            for (int i = 0; i <= digit; i++)
            {
                dpCases[i] = new long[K + 2][];
                for (int k = 0; k <= K + 1; k++)
                {
                    dpCases[i][k] = new long[]{0, 0};
                }
            }

            dpCases[0][0][0] = 1;
            for (int i = 1; i <= digit; i++)
            {
                for (int k = 0; k <= K; k++)
                {
                    // when f = 0
                    if (N[i] == 0)
                    {
                        dpCases[i][k][0] += dpCases[i - 1][k][0];
                    }
                    else
                    {
                        dpCases[i][k + 1][0] += dpCases[i - 1][k][0];
                        dpCases[i][k + 1][1] += dpCases[i - 1][k][0] * (N[i] - 1);
                        dpCases[i][k][1] += dpCases[i - 1][k][0];
                    }

                    dpCases[i][k + 1][1] += dpCases[i - 1][k][1] * 9;
                    dpCases[i][k][1] += dpCases[i - 1][k][1];
                }
            }

            WriteLine(dpCases[digit][K].Sum().ToString());
            ReadKey();
        }
    }
}