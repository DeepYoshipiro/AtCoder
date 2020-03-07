using System;
using System.Linq;

namespace AtCoderBeginnersSelection
{
    class Prob08Sim1
    {
        static void Main(string[] args)
        {
            // input
            int[][] c = new int[3][];
            c[0] = Console.ReadLine().Split(' ')
                        .Select(n => int.Parse(n)).ToArray();
            c[1] = Console.ReadLine().Split(' ')
                        .Select(n => int.Parse(n)).ToArray();
            c[2] = Console.ReadLine().Split(' ')
                        .Select(n => int.Parse(n)).ToArray();

            // calculate
            bool[][] result = new bool[6][];
            for (int i = 0; i < 6; i++) {
                for (int j = 0; j <= 100; j++) {
                    result[i][j] = false;
                }
            }

            //a（横の行の初期化）
            for (int i = 0; i < 3; i++) {
                int maxA = c[i].Max();
                for (int j = 0; j <= maxA; j++) {
                    result[i][j] = true;
                }
            }

            //b（縦の列の初期化）
            for (int j = 0; j < 3; j++) {
                int maxB = ;
                for (int i = 0; i <= maxB; i++) {
                    result[j + 3][i] = true;
                }
            }

            // output
            Console.WriteLine(result.ToString());
        }
    }
}
