using System;
using System.Linq;
using static System.Console;
using static System.Math;

namespace _300pt
{

    class ARC066C
    {
        static void Main(string[] args)
        {
            const int mod = 1000000007;

            //input
            int N = int.Parse(ReadLine());
            int[] A = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();

            //calculate
            int[] correctCase = new int[N];
            for (int i = 0; i < N; i++)
            {
                correctCase[Abs(i - (N - 1 - i))]++;
            }

            int[] P = new int[N];
            Array.Copy(correctCase, P, N);

            for (int i = 0; i < N; i++)
            {
                P[A[i]]--;
            }

            int result = 1;
            for (int i = (N + 1) % 2; i < N; i += 2)
            {
                if (P[i] != 0) result = 0;
                result = (result * correctCase[i]) % mod;
            }

            //output;
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
