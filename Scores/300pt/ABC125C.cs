using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ABC125C
    {
        // DP

        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());

            int[] A = ReadLine().Split()
                .Select(n => int.Parse(n))
                .OrderByDescending(n => n).ToArray();
            int firstLargeNum = A[0];
            int secondLargeNum = A[1];

            int[][] dpGCD = new int[3][];
            for (int j = 0; j <= 2; j++)
            {
                dpGCD[j] = new int[N];
            }
            dpGCD[0][0] = A[0];
            dpGCD[1][0] = A[0];
            dpGCD[2][0] = A[1];

            NumberTheory nt = new NumberTheory();
            for (int i = 1; i < N; i++)
            {
                dpGCD[0][i] = nt.GCD(dpGCD[0][i - 1], A[i]);
                dpGCD[1][i] =
                     Max(nt.GCD(dpGCD[0][i - 1], firstLargeNum)
                        , nt.GCD(dpGCD[1][i - 1], A[i]));
                dpGCD[2][i] =
                     Max(nt.GCD(dpGCD[0][i - 1], secondLargeNum)
                        , nt.GCD(dpGCD[2][i - 1], A[i]));
            }

            WriteLine(Max(dpGCD[1][N - 1], dpGCD[2][N - 1]));
            ReadKey();
        }

        class BaseAlgorithm
        {
            internal void Swap(ref int A, ref int B)
            {
                int tmp = A;
                A = B;
                B = tmp;
            }
        }

        class NumberTheory
        {
            internal int GCD(int A, int B)
            {
                if (A < B)
                {
                    BaseAlgorithm ba = new BaseAlgorithm();
                    ba.Swap(ref A, ref B);
                }

                int R = A;

                while (R > 0)
                {
                    R = A % B;
                    A = B;
                    B = R;
                }
                return A;
            }
        }
    }
}
