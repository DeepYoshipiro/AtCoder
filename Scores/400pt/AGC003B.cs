using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class AGC003B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());

            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(ReadLine());
            }

            long result = 0;
            result += A[0] / 2;
            A[0] %= 2;
            for (int i = 1; i < N; i++)
            {
                if (A[i - 1] == 1 && A[i] > 0)
                {
                    result++;
                    A[i - 1]--;
                    A[i]--;
                }
                result += A[i] / 2;
                A[i] %= 2;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}