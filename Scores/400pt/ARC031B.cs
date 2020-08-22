// Solution : DFS
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ARC031B
    {
        static readonly int LAND_LENGTH = 10;

        static void Main(string[] args)
        {
            char[][] land = new char[LAND_LENGTH][];

            var baseLandCnt = 0;
            var baseStartY = -1;
            var baseStartX = -1;

            var searched = new bool[LAND_LENGTH][];

            for (int u = 0; u < LAND_LENGTH; u++)
            {
                land[u] = ReadLine().ToCharArray();
                searched[u] = new bool[LAND_LENGTH];

                for (int v = 0; v < LAND_LENGTH; v++)
                {
                    if (land[u][v] == 'o')
                    {
                        baseLandCnt++;
                        if (baseStartY < 0)
                        {
                            baseStartY = u;
                            baseStartX = v;
                        }
                    }
                }
            }

            var coverLandCnt = DFS(baseStartY, baseStartX, searched, land);
            if (coverLandCnt == baseLandCnt)
            {
                WriteLine("YES");
                ReadKey();
                return;
            }

            bool result = false;
            var embedLandCnt = ++baseLandCnt;
            for (int i = 0; i < LAND_LENGTH; i++)
            {
                for (int j = 0; j < LAND_LENGTH; j++)
                {
                    var embedSearched = new bool[LAND_LENGTH][];
                    for (int u = 0; u < LAND_LENGTH; u++)
                    {
                        embedSearched[u] = new bool[LAND_LENGTH];
                    }

                    if (land[i][j] == 'o') continue;
                    land[i][j] = 'o';
                    var coverEmbedLandCnt = DFS(baseStartY, baseStartX, embedSearched, land);
                    land[i][j] = 'x';
                    if (coverEmbedLandCnt == embedLandCnt)
                    {
                        result = true;
                        break;
                    }
                }
                if (result) break;
            }

            WriteLine(result ? "YES" : "NO");
            ReadKey();
        }

        static int DFS(int posY, int posX, bool[][] searched, char[][] land)
        {
            if (posY < 0 || posY >= LAND_LENGTH) return 0;
            if (posX < 0 || posX >= LAND_LENGTH) return 0;
            if (land[posY][posX] == 'x') return 0;
            if (searched[posY][posX]) return 0;

            int result = 1;
            searched[posY][posX] = true;

            int[] dy = new int[]{-1, 0, 0, 1};
            int[] dx = new int[]{0, -1, 1, 0};

            for (int h = 0; h < dy.Count(); h++)
            {
                var nextSearched = (bool[][])searched.Clone();
                result += DFS(posY + dy[h], posX + dx[h], nextSearched, land);
            }

            return result;
        }
    }
}
