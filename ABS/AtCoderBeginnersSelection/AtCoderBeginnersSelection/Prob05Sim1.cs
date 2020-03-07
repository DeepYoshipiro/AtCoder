using System;
using static System.Console;

namespace AtCoderBeginnersSelection
{
    class Prob05Sim1
    {
        static void Main(string[] args)
        {
            // input
            int N = int.Parse(ReadLine());

            // calculate
            int fX = 0;
            int tmp = N;
            for (int i = 0; i <= Math.Log10(N); i++) {
                int ketaNum = tmp % 10;
                fX += ketaNum;
                tmp -= ketaNum;
                tmp /= 10;
            }

            // output
            string result = (N % fX == 0 ? "Yes" : "No");
            WriteLine(result.ToString());
        }
    }
}
