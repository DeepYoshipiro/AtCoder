using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ETC
{
    class ATC001A
    {
        static int H;
        static int W;
        static char[][] status;
        static bool reachAble = false;

        static void Main(string[] args)
        {
            int[] measure = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            H = measure[0];
            W = measure[1];

            int startX = int.MaxValue;
            int startY = int.MaxValue;

            status = new char[H][];
            for (int i = 0; i < H; i++) {
                status[i] = ReadLine().ToCharArray();
                if (status[i].Contains('s')) {
                    startX = status[i].ToString().IndexOf('s') - 1;
                    startY = i;
                }
            }

            bool[][] visited = new bool[H][];
            for (int i = 0; i < H; i++) {
                visited[i] = new bool[W];
            }
            FindWay(startX, startY, visited);

            WriteLine(reachAble ? "Yes" : "No");
            ReadKey();
        }

        private static void FindWay
            (int x, int y, bool[][] prevVisited)
        {
            if (reachAble) return;

            bool[][] curVisited = (bool[][])prevVisited.Clone();
            if (x < 0 || x >= W || y < 0 || y >= H) return;
            if (status[y][x].Equals('#') || prevVisited[y][x]) return;
            if (status[y][x].Equals('g')) { reachAble = true; return; }

            curVisited[y][x] = true;

            FindWay(x - 1, y, (bool[][])curVisited.Clone());
            FindWay(x + 1, y, (bool[][])curVisited.Clone());
            FindWay(x, y - 1, (bool[][])curVisited.Clone());
            FindWay(x, y + 1, (bool[][])curVisited.Clone());
            return;
        }
    }
}
