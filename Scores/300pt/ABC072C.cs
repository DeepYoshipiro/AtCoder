using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

namespace _300pt
{
    class ABC072C
    {
        static void Main(string[] args)
        {
            const int MAX = 100000;
            int N = int.Parse(ReadLine());
            int[] a = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();

            int[] numCnt = new int[MAX + 1];
            for (int i = 0; i < N; i++)
            {
                numCnt[a[i]]++;
            }

            int result = 0;
            for (int j = 1; j <= MAX - 1; j++)
            {
                int nominee = numCnt[j - 1] + numCnt[j] + numCnt[j + 1];
                if (result < nominee) result = nominee;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}