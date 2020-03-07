using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace SumiTrust2019
{
    class SumiTrust2019E
    {
        static void Main(string[] args)
        {
            long mod = (long)Pow(10, 9) + 7;           

            int N = int.Parse(ReadLine());
            int[] A = Console.ReadLine().Split(' ')
                        .Select(n => int.Parse(n))
                        .ToArray();

            int[] call = new int[N];
            long result = 1;
            for (int i = 0; i < N; i++)
            {
                call[A[i]]++;
            }

            for (int i = 1; i < N; i++)
            {
                switch (A[i])
                {
                    case 0:
                        break;
                    case 1:
                        break;
                    case 2:
                        result *= 2;
                        result %= mod;
                        break;
                    case 3:
                        result *= 6;
                        result %= mod;
                        break;
                }
            }

            switch (result)
            {
                case 1:
                    result = 3;
                    break;
                case 2:
                    result = 6;
                    break;
                default:
                    break;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}