using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC151
{
    class ABC151D
    {
        static int H;
        static int W;
        static void Main(string[] args)
        {
            ABC151D my = new ABC151D();
            int[] init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            H = init[0];
            W = init[1];

            char[][] S = new char[H][];
            for (int i = 0; i < H; i++)
            {
                S[i] = ReadLine().ToCharArray();
            }

            int result = 0;
            for (int i = 0; i < H; i++)
            {
                for (int j = 0; j < W; j++)
                {
                    if (S[i].Equals('#'))
                    {
                        continue;
                    }
                    char[][] maze = (char[][])S.Clone();
                    int current = my.dfs(0, i, j, maze);
                    if (current > result) 
                    {
                        result = current;
                        if (result == H + W - 2) break;
                    }
                }
            }
            WriteLine(result.ToString());
            ReadKey();
        }

        internal int dfs(int move, int h, int w, char[][] maze)
        {
            if (h < 0 || h >= H || w < 0 || w >= W) return move;
            if (maze[h][w].Equals('#')) return move;
            if (maze[h][w].Equals('$')) return move + 1;
            move++;
            maze[h][w] = '$';
            char[][] mazeUp = (char[][])maze.Clone();
            dfs(move, h - 1, w, mazeUp);

            char[][] mazeLeft = (char[][])maze.Clone();
            dfs(move, h, w - 1, mazeLeft);

            char[][] mazeRight = (char[][])maze.Clone();
            dfs(move, h, w + 1, mazeRight);

            char[][] mazeDown = (char[][])maze.Clone();
            dfs(move, h + 1, w, mazeDown);
            return move;
        }
    }
}
