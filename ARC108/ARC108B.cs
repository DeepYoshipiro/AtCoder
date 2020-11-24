using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ARC108
{
    class ARC108B
    {
        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());
            var S = ReadLine().ToCharArray();
            int result = N;
            var F = new int[N];
            var O = new int[N];
            var X = new int[N];

            if (S[0] == 'f') F[0]++;
            for (int i = 1; i < N; i++)
            {
                F[i] = F[i - 1];
                O[i] = O[i - 1];
                X[i] = X[i - 1];
                switch (S[i])
                {
                    case 'f':
                        F[i] = F[i - 1] + 1;
                        break;
                    case 'o':
                        O[i] = O[i - 1] + 1;
                        if (O[i] > F[i] || X[i] > O[i])
                        { 
                            // Reset(i, F, O, X);
                            F[i] = 0;
                            O[i] = 0;
                            X[i] = 0;
                        }
                        break;
                    case 'x':
                        X[i] = X[i - 1] + 1;
                        if (X[i] > O[i] || X[i] > F[i])
                        {
                            // Reset(i, F, O, X);
                            F[i] = 0;
                            O[i] = 0;
                            X[i] = 0;
                            break;
                        }
                        while (F[i] >= O[i] && O[i] >= X[i] && X[i] > 0)
                        {
                            result -= 3;
                            F[i]--;
                            O[i]--;
                            X[i]--;
                        }
                        break;
                    default:
                        // Reset(i, F, O, X);
                        F[i] = 0;
                        O[i] = 0;
                        X[i] = 0;
                        break;
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }

        // static void Reset(int i, int[] F, int[] O, int[] X)
        // {
        //     F[i] = 0;
        //     O[i] = 0;
        //     X[i] = 0;
        //     return;
        // }
    }
}
