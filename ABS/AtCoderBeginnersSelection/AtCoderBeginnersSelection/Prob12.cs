using System;
using System.Linq;
using static System.Console;
using static System.Math;

namespace AtCoderBeginnersSelection
{
    class Prob12
    {
        static void Main(string[] args)
        {
            // input
            int[] input = ReadLine().Split(' ')
                        .Select(n => int.Parse(n)).ToArray();

            int aliceBegin = input[0];
            int aliceEnd = input[1];
            int bobBegin = input[2];
            int bobEnd = input[3];

            // calculate
            int begin = Max(aliceBegin, bobBegin);
            int end = Min(aliceEnd, bobEnd);

            int result = end - begin;
            if (result < 0) result = 0;

            // output
            WriteLine(result.ToString());
        }
    }
}
