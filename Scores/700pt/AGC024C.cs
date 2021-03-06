using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

namespace _700pt
{
    class AGC024C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());

            long[] A = new long[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = long.Parse(ReadLine());
            }

            bool possible = true;
            if (A[0] > 0) possible = false;
            for (int i = 1; i < N; i++)
            {
                if (A[i - 1] + 1 < A[i]) possible = false;
            }

            if (!possible)
            {
                WriteLine("-1");
                ReadKey();
                return;
            }
        
            long result = 0;
            for (int i = N - 1; i > 0; i--)
            {
                result += (A[i] - A[i - 1] == 1)
                    ? 1 : A[i];
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}