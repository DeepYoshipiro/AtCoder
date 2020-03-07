using System;
using static System.Console;

namespace AtCoderBeginnersSelection
{
    class Prob04Sim1
    {
        static void Main(string[] args)
        {
            // input
            int N = int.Parse(ReadLine());

            // calculate
            bool exist = false;
            for (int c = 0; c <= (N + 1) / 4; c++)
            {
                for (int d = 0; d <= (N + 1) / 7; d++)
                {
                    if (c * 4 + d * 7 == N)
                    {
                        exist = true;
                        break;
                    }
                }
                if (exist) break;
            }


            // output
            string result = (exist ? "Yes" : "No");
            WriteLine(result.ToString());
        }
    }
}
