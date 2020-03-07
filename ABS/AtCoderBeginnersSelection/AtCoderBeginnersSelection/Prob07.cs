using System;
using static System.Console;

namespace AtCoderBeginnersSelection
{
    class Prob07
    {
        static void Main(string[] args)
        {
            // input
            int N = int.Parse(ReadLine());
            int[] d = new int[N];
            for (int i = 0; i < N; i++) {
                d[i] = int.Parse(ReadLine());
            }

            // calculate
            Array.Sort(d);  //昇順に並べて

            int result = 0;
            int maxDiameter = 0;
            for (int i = 0; i < N; i++) {
                // 半径の小さい順に組み立ててくことにした
                if (d[i] > maxDiameter) {
                    result++;
                    maxDiameter = d[i];
                }
            }

            // output
            WriteLine(result);
        }
    }
}