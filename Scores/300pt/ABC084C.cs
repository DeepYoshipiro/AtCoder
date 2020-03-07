using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ABC084C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            int[] C = new int[N];
            int[] S = new int[N];
            int[] F = new int[N];
            for (int i = 1; i <= N - 1; i++)
            {
                int[] dia = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                C[i] = dia[0];
                S[i] = dia[1];
                F[i] = dia[2];
            }

            int[] result = new int[N];
            for (int i = N - 1; i >= 1; i--)
            {
                int elapsedTime = S[i];
                for (int j = i; j <= N - 1; j++)
                {
                    if (elapsedTime < S[j])
                    {
                        elapsedTime = S[j];
                    }
                    else
                    {
                        int waitTime = (F[j] - (elapsedTime % F[j])) % F[j];
                        elapsedTime += waitTime; 
                    }
                    elapsedTime += C[j];
                }
                result[i] = elapsedTime;
            }

            for (int i = 1; i < N; i++)
            {
                WriteLine(result[i].ToString());
            }
            WriteLine("0");
            ReadKey();
        }
    }
}