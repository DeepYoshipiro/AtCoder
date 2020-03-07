using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace TeaBreak003
{
    class TeaBreak003D
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            List<int> A = Console.ReadLine().Split(' ')
                    .Select(n => int.Parse(n)).ToList();

            int result = N;
            for (int start = 0; start < N; start++)
            {
                List<int> B = new List<int>(A);
                int removePos = start;
                int trial = 0;
                while (B.Count > 0)
                {
                    trial++;
                    int removeCnt = B[removePos];
                    if (B.Count <= removeCnt) break;
                    for (int i = 1; i <= removeCnt; i++)
                    {
                        B.RemoveAt(removePos);
                        if (removePos >= B.Count)
                            removePos = 0;
                    }
                }
                if (result > trial) result = trial;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
