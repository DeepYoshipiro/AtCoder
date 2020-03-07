using System;
using static System.Console;

namespace AtCoderBeginnersSelection
{
    class Prob04
    {
        static void Main(string[] args)
        {
            // input
            int A = int.Parse(ReadLine());  //500円玉
            int B = int.Parse(ReadLine());  //100円玉
            int C = int.Parse(ReadLine());  //50円玉
            int X = int.Parse(ReadLine());  //合計額


            // calculate
            int result = 0;
            for (int yen500 = 0; yen500 <= A; yen500++) {
                for (int yen100 = 0; yen100 <= B; yen100++) {
                    for (int yen50 = 0; yen50 <= C; yen50++)
                        if (yen500 * 500 + yen100 * 100 + yen50 * 50 == X) result++;
                }
            }

            // output
            WriteLine(result);
        }
    }
}

