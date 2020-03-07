using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ABC087C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            int[][] A = new int[2][];
            A[0] = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            A[1] = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();

            int result = A[0].Sum() + A[1][N - 1];
            int curSum = result;
            for (int i = N - 1; i > 0; i--)
            {
                curSum -= A[0][i];
                curSum += A[1][i - 1];
                if (result < curSum) result = curSum;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}