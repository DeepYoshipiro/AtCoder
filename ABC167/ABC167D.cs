using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC167
{
    class ABC167D
    {
        static void Main(string[] args)
        {
            // var N = int.Parse(ReadLine());
            
            // var N = long.Parse(ReadLine());
            long[] init = ReadLine().Split()
                .Select(n => long.Parse(n)).ToArray();
            var N = (int)init[0];
            var K = init[1];

            int[] A = (new int[]{0})
                .Concat(ReadLine().Split()
                .Select(n => int.Parse(n))).ToArray();

            long[] visited = new long[N + 1];
            List<long> visitRecord = new List<long>();
            for (int i = 1; i <= N; i++)
            {
                visited[i] = -1;
            }
            long firstSecondVisited = 0;
            long circle = 0;
            long curPos = 1;
            visited[1] = 0;
            visitRecord.Add(1);
            for (int i = 1; i <= K; i++)
            {
                long nextVisit = A[curPos];
                if (visited[nextVisit] < 0)
                {
                    visited[nextVisit] = i;
                    visitRecord.Add(nextVisit);
                    curPos = nextVisit;
                }
                else
                {
                    firstSecondVisited = i;
                    circle = i - visited[nextVisit];
                    break;
                }
            }

            if (firstSecondVisited > 0)
            {
                int teleport = 
                    (int)(visited[A[curPos]] 
                    + (K - firstSecondVisited) % circle);
                curPos = visitRecord[teleport];
            }

            WriteLine(curPos.ToString());
            ReadKey();
        }
    }
}
