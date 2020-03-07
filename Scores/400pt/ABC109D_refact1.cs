using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ABC109D_refact1
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            int H = init[0];
            int W = init[1];

            int[][] a = new int[H][];
            List<Move> move = new List<Move>();

            int N = 0;
            for (int i = 0; i < H; i++)
            {
                a[i] = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                for (int j = 0; j < W - 1; j++)
                {
                    if (a[i][j] % 2 != 0)
                    {
                        a[i][j]--;
                        a[i][j + 1]++;
                        move.Add(new Move(i, j, i, j + 1));
                        N++;
                    }
                }
            }

            for (int i = 0; i < H - 1; i++)
            {
                if (a[i][W - 1] % 2 != 0)
                {
                    a[i][W - 1]--;
                    a[i + 1][W - 1]++;
                    move.Add(new Move(i, W - 1, i + 1, W - 1));
                    N++;
                }
            }

            WriteLine(N.ToString());

            foreach (Move cur in move)
            {
                WriteLine("{0} {1} {2} {3}", cur.fromY, cur.fromX, cur.toY, cur.toX);
            }
            ReadKey();
        }
    }

    internal class Move
    {
        public int fromY { get ;}
        public int fromX { get ;}
        public int toY { get ;}
        public int toX { get ;}

        public Move(int fromY, int fromX, int toY, int toX)
        {
            this.fromY = fromY + 1;
            this.fromX = fromX + 1;
            this.toY = toY + 1;
            this.toX = toX + 1;
        }
    }
}
