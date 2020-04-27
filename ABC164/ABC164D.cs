using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

namespace ABC164
{
    class ABC164D
    {
        static void Main(string[] args)
        {
            char[] S = ReadLine().ToCharArray();

            int[] r = new int[S.Length + 1];
            r[0] = 1;
            for (int i = 1; i <= S.Length; i++)
            {
                r[i] = r[i - 1] * 10;
                r[i] %= 2019;
                // if (r[i] == 1) WriteLine(i);
            }

            long result = 0;
            for (int j = S.Length - 1; j >= 3; j--)
            {
                long Sum = S[j] - '0';
                for (int i = j - 1; i >= 0; i--)
                {
                    Sum += (S[i] - '0') * r[j - i];
                    Sum %= 2019;
                    if (Sum == 0) result++;
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
