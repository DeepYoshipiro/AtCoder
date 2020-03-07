using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ABC135D
    {
        static void Main(string[] args)
        {
            char[] S = ReadLine().Reverse().ToArray();

            int[][] digitReminder = new int[S.Length][];
            long[][] dpComb = new long[S.Length][];

            digitReminder[0] = new int[10]{0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            dpComb[0] = new long[13];
            for (int d = 1; d < S.Length; d++)
            {
                digitReminder[d] = new int[10];
                dpComb[d] = new long[13];

                for (int i = 0; i <= 9; i++)
                {
                    digitReminder[d][i] = (digitReminder[d - 1][i] * 10) % 13;
                }
            }

            if (S[0].Equals('?'))
            {
                dpComb[0] = new long[13]{1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0};
            }
            else
            {
                dpComb[0] = new long[13];
                dpComb[0][S[0] - '0'] = 1;
            }

            for (int d = 1; d < S.Length; d++)
            {
                int numberOfDigit;
                int to;
                if (S[d].Equals('?'))
                {
                    for (int x = 0; x <= 9; x++)
                    {
                        numberOfDigit = x;
                        for (int r = 0; r < 13; r++)
                        {
                            to = r + digitReminder[d][numberOfDigit]; 
                            to %= 13;
                            dpComb[d][to] += dpComb[d - 1][r];
                            dpComb[d][to] %= (long)Pow(10, 9) + 7;
                        }
                    }
                }
                else
                {
                    numberOfDigit = S[d] - '0';
                    for (int r = 0; r < 13; r++)
                    {
                        to = r + digitReminder[d][numberOfDigit]; 
                        to %= 13;
                        dpComb[d][to] = dpComb[d - 1][r];
                    }
                }
            }
            WriteLine(dpComb[S.Length - 1][5].ToString());
            ReadKey();
        }
    }
}