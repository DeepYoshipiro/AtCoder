using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _700pt
{
    class AGC031B
    {
        static int N;

        static List<int> C;

        static int[] nextSameCpos;

        static long[] dpWay;

        static void Main(string[] args)
        {
            const int MAX_C = 200000;
            N = int.Parse(ReadLine());

            int prevC = 0;

            C = new List<int>();
            var appearedSameCpos = new int[MAX_C + 1]
                        .Select(v => -1).ToArray();
            nextSameCpos = new int[N]
                        .Select(v => -1).ToArray();
            for (int i = 0; i < N; i++)
            {
                int curC = int.Parse(ReadLine());
                if (curC == prevC) continue;
                C.Add(curC);
                if (appearedSameCpos[curC] >= 0)
                {
                    var prevSameCpos = appearedSameCpos[curC];
                    nextSameCpos[prevSameCpos] = C.Count() - 1;
                }
                appearedSameCpos[curC] = C.Count() - 1;
                prevC = curC;
            }

            N = C.Count();
            dpWay = new long[N].Select(v => -1L).ToArray();
            long result = DFS(0);

            WriteLine(result.ToString());
            ReadKey();
        }

        static long DFS(int pos)
        {
            long mod = (long)(Pow(10, 9) + 7);
            if (pos == N - 1) return 1;
            if (dpWay[pos] >= 0) return dpWay[pos];
            
            long result = 0;
            if (nextSameCpos[pos] > 0)
            {
                result += DFS(nextSameCpos[pos]);
            }
            result += DFS(pos + 1);
            result %= mod;

            return dpWay[pos] = result;
        }
    }
}
