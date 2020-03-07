using System;
using System.Linq;
using static System.Console;

namespace AtCoderBeginnersSelection
{
    class Prob05
    {
        static void Main(string[] args)
        {
            // input
            int[] input = ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();
            int N = input[0];
            int A = input[1];
            int B = input[2];

            // calculate
            int result = 0;
            for (int i = 1; i <= N; i++) {
                char[] ketaNum = i.ToString().ToCharArray();
                int ketaSum = 0;
                for (int j = 0; j < ketaNum.Length; j++) {
                    ketaSum += int.Parse(ketaNum[j].ToString());
                }

                if (A <= ketaSum && ketaSum <= B) {
                    result += i;
                }
            }

            // output
            WriteLine(result);
        }
    }
}
