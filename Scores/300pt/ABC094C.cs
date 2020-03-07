using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ABC094C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            List<int> X = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToList();

            List<int> sortedX = new List<int>(X);
            sortedX.Sort();
            int upperMedian = sortedX[N / 2];
            int lowerMedian = sortedX[N / 2 - 1];

            for (int i = 0; i < N; i++)
            {
                int result
                     = (X[i] <= lowerMedian ? upperMedian : lowerMedian);

                WriteLine(result.ToString());
            }

            ReadKey();
        }
    }
}
