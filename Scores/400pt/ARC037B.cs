// Solution: DFS
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ARC037B
    {
        static List<int>[] way;
        static int[] treeNo;

        static int[] wayCntinColor;

        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var N = init[0];  
            var M = init[1];

            way = new List<int>[N + 1];
            for (int i = 1; i <= N; i++)
            {
                way[i] = new List<int>(); 
            }

            for (int j = 0; j < M; j++)
            {
                var edge = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                way[edge[0]].Add(edge[1]);
                way[edge[1]].Add(edge[0]);
            }

            int curTreeCnt = 0;
            int includeCircle = 0;
            int searchedTree = 0;
            treeNo = new int[N + 1];
            wayCntinColor = new int[N + 1];
            for (int i = 1; i <= N; i++)
            {
                if (treeNo[i] > 0) continue;
                treeNo[i] = ++curTreeCnt;
                foreach (int to in way[i])
                {
                    DFS(to, curTreeCnt);
                }
            }

            WriteLine("{0} - {1} = ", curTreeCnt, includeCircle);
            for (int i = 1; i <= curTreeCnt; i++)
                WriteLine(wayCntinColor[i]);
            ReadKey();
        }

        static void DFS(int from, int curTreeCnt)
        {            
            if (treeNo[from] > 0)
            {
                return;
            }

            wayCntinColor[curTreeCnt]++;
            treeNo[from] = curTreeCnt;
            foreach (int to in way[from])
            {
                DFS(to, curTreeCnt);
            }

            return;
        }
    }
}