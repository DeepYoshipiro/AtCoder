using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC154
{
    class ABC154E
    {
        static void Main(string[] args)
        {
            char[] N = ReadLine().ToCharArray();
            int K = int.Parse(ReadLine());  // not 0

            long result = 0;
            for (int i = 1; i < N[0] - '0'; i++)
            {
                result += f(N, N.Length - 1, K);
            }

            for (int j = 1; j < N.Length; j++)
            {
                result += f(N.Length - 2, K);
                for (int i = 1; i < N[1] - '0'; i++)
                {
                    result += f(N.Length - 2, K - 1);
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }

        static long f(char[] N, int digit, int nonZero)
        {
            if (digit < nonZero) return 0;
            if (digit == nonZero) return 1;
            long ret = 1;
            int n = digit;
            for (int k = nonZero; k >= 1; k--)
            {
                ret *= digit;
                digit--;
            }
            for (int k = nonZero; k >= 1; k--)
            {
                ret /= k;
            }
            ret += f((char[])N.Clone(),digit - 1, nonZero);

        }
    }
}
