using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC184
{
    class ABC184D
    {
        static int caseCnt = 0;

        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var A = init[0];
            var B = init[1];
            var C = init[2];

            double result = DFS(0, 1, A, B, C);

            WriteLine(result.ToString());
            ReadKey();
        }

        static double DFS(int trial, double prob, int A, int B, int C)
        {
            if (A >= 100 || B >= 100 || C >= 100)
            {
                return trial * prob;
            }
            
            double result = DFS(trial + 1, prob * A / (A + B + C), A + 1, B, C);
            result += DFS(trial + 1, prob * B / (A + B + C), A, B + 1, C);
            result += DFS(trial + 1, prob * C / (A + B + C), A, B, C + 1);

            return result;            
        }
    }
}
