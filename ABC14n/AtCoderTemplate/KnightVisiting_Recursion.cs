using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace Stack
{
    public class KnightVisiting_Recursion {
        public static int M;
        public static int N;
        public static int[][] board;

        static void Main(string[] args)
        {
            KnightVisiting_Recursion my = new KnightVisiting_Recursion();
            M = 4;
            N = 4;

            board = new int[M][];
            for (int m = 0; m < M; m++)
            {
                board[m] = new int[N];
            }

            WriteLine(my.bfs(1, 0, 0) ? "Yes" : "No");
            ReadKey();
        }

        internal bool bfs(int i, int v, int h)
        {
            if (v < 0 || v >= M || h < 0 || h >= N)
                return false;
            if (board[v][h] > 0) return false;

            board[v][h] = i;
            WriteLine("★Progress★");
            printBoard();
            if (i == N * M)
            {
                return true;
            }

            int[] dv = {-2, -1, 1, 2, 2, 1, -1, -2};
            int[] dh = {1, 2, 2, 1, -1, -2, -2, -1};

            for (int t = 0; t < dv.Length; t++)
            {
                if (bfs(i + 1, v + dv[t], h + dh[t])) return true;
            }
            
            board[v][h] = 0;
            WriteLine("▽Recess▽");
            printBoard();
            return false;
        }

        internal void printBoard()
        {
            for (int v = 0; v < M; v++)
            {
                for (int h = 0; h < N; h++)
                {
                    Write(board[v][h] + " ");
                }
                WriteLine("");
            }
            WriteLine();
            ReadKey();
        }
    }
}