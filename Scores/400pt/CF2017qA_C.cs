using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class CF2017qA_C
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
            int H = init[0];
            int W = init[1];

            int[,] group = new int[H, W];
            int grpCnt = 0;
            List<int> demandChrCnt = new List<int>();

            char[][] a = new char[H][];
            int[] chrCnt = new int['z' - 'a' + 1];
            for (int h = 0; h < H; h++)
            {
                a[h] = ReadLine().ToCharArray();
                for (int w = 0; w < W; w++)
                {
                    chrCnt[a[h][w] - 'a']++;
                    if (group[h, w] == 0)
                    {
                        int sameGrpCnt = 1;
                        grpCnt++;
                        group[h, w] = grpCnt;
                        if (group[h, W - 1 - w] == 0) 
                        {
                            group[h, W - 1 - w] = grpCnt;
                            sameGrpCnt++;
                        }
                        if (group[H - 1 - h, w] == 0)
                        {
                            group[H - 1 - h, w] = grpCnt;
                            sameGrpCnt++;
                        }
                        if (group[H - 1 - h, W - 1 - w] == 0)
                        {
                            group[H - 1 - h, W - 1 - w] = grpCnt;
                            sameGrpCnt++;
                        }
                        demandChrCnt.Add(sameGrpCnt);
                    }
                }
            }
            demandChrCnt.Sort();
            demandChrCnt.Reverse();
 
            List<int> supplyChrCnt = chrCnt.Where(n => n > 0)
                    .OrderByDescending(n => n).ToList();
            bool result = true;
            while (demandChrCnt.Count > 0)
            {
                if (demandChrCnt.First() <= supplyChrCnt.First())
                {
                    int remain = supplyChrCnt.First() - demandChrCnt.First();
                    demandChrCnt.RemoveAt(0);
                    supplyChrCnt.RemoveAt(0);
                    if (remain > 0)
                    {
                        supplyChrCnt.Add(remain);
                        supplyChrCnt.Sort();
                        supplyChrCnt.Reverse();
                    }
                }
                else
                {
                    result = false;
                    break;
                }
            }
            if (supplyChrCnt.Count > 0) result = false;

            WriteLine(result ? "Yes" : "No");
            ReadKey();
        }
    }
}