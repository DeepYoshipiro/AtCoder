using System;
using System.Linq;
using static System.Console;

namespace AtCoderBeginnersSelection
{
    class Prob06Sim1
    {
        static void Main(string[] args)
        {
            // input
            int[] input = ReadLine().Split(' ')
                        .Select(n => int.Parse(n)).ToArray();

            int N = input[0];
            int K = input[1];

            int[] length = ReadLine().Split(' ')
                        .Select(n => int.Parse(n))
                        .OrderByDescending(m=>m).ToArray();

            // calculate
            int result = 0;
            for (int i = 0; i < K; i++) {
                result += length[i];
            }

            // output
            WriteLine(result.ToString());
        }
    }
}
