using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

namespace _300pt
{
    class AGC028A
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int M = init[1];

            char[] S = ReadLine().ToCharArray();
            char[] T = ReadLine().ToCharArray();

            int a = Max(N, M);
            int b = Min(N, M);
            int r = a % b;
            while (r > 0)
            {
                a = b;
                b = r;
                r = a % b;
            }
            int gcd = b;
            int LCM = N / gcd * M;

            bool result = true;
            for (int i = 0; i < gcd; i++)
            {
                if (S[LCM / M * i] != T[LCM / N * i])
                {
                    result = false;
                    break;
                }
            }

            if (result)
            {
                WriteLine(LCM.ToString());
            }
            else
            {
                WriteLine("-1");
            }
            ReadKey();
        }
    }
}           