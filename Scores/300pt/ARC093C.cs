using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ARC093C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            int[] pad0 = new int[]{0};
            int[] A = pad0.Concat(ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray()).ToArray();
            A = A.Concat(new int[]{0}).ToArray();

            int sum = 0;
            for (int i = 0; i <= N; i++)
            {
                sum += Abs(A[i + 1] - A[i]);
            }

            for (int i = 1; i <= N; i++)
            {
                int result = sum;
                result -= Abs(A[i + 1] - A[i]) + Abs(A[i] - A[i - 1]);
                result += Abs(A[i + 1] - A[i - 1]);
                WriteLine(result.ToString());
            }
            
            ReadKey();
        }
    }
}
