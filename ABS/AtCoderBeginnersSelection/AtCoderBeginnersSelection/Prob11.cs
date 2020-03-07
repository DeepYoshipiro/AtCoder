using System;
using System.Linq;
using static System.Console;

namespace AtCoderBeginnersSelection
{
    class Prob11
    {
        static void Main(string[] args)
        {
            // input
            int[] input = ReadLine().Split(' ')
                        .Select(n => int.Parse(n)).ToArray();

            int H = input[0];    //縦(Height)
            int W = input[1];    //横(Width)

            char[][] S = new char[H][];
            const char SAFE = '.';
            const char OUT = '#';

            for (int i = 0; i < H; i++) {
                S[i] = ReadLine().ToCharArray();
            }

            // calculate
            int[] searchH = { -1, -1, -1, 0, 0, 1, 1, 1 };
            int[] searchW = { -1, 0, 1, -1, 1, -1, 0, 1 };

            for (int i = 0; i < H; i++) {
                for (int j = 0; j < W; j++)
                {
                    if (S[i][j].Equals(SAFE))
                    {
                        int outGrid = 0;
                        for (int k = 0; k < searchH.Length; k++)
                        {
                            if ((i+searchH[k]>=0 && i +searchH[k] < H)&&  (j+searchW[k] >= 0)&&(j+searchW[k] < W))
                                if (S[i+searchH[k]][j+searchW[k]].Equals(OUT)) outGrid++;
                        }
                        S[i][j] = char.Parse(outGrid.ToString());
                    }
                }
            }

            // output
            for (int i = 0; i < H; i++) {
                WriteLine(S[i]);
            }
        }
    }
}
