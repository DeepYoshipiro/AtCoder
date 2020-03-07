using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC152
{
    class ABC152D
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());

            long result = 0;
            int digitN = (int)Log10(N);
            for (int i = 1; i <= N; i++)
            {
//            int i = N;
                int A = i;
                int digitA = (int)Log10(i);
                int firstA = i / (int)Pow(10, digitA);
                int lastA = i % 10;

                if (lastA == 0) continue;
                // 1けたの当てはまるB
                if (firstA == lastA) result++;
                // 2けたの当てはまるB
                if (lastA * 10 + firstA <= N) result++; 
                // d + 1けたの当てはまるB
                for (int d = 2; d <= digitN; d++)
                {
                    int satisfy = (N - (lastA * (int)Pow(10, d) + firstA - 10)) / 10;
                    if (satisfy < 0) satisfy = 0;
                    if (satisfy > (int)Pow(10, d - 1)) satisfy = (int)Pow(10, d - 1);
                    result += satisfy;
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}