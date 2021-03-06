using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ACLBC
{
    class ACLBC_D
    {
        internal class Process
        {
            internal int PrevIdx{get;}
            internal int SeqLeng{get; set;}
            internal int PrevValue{get;}

            internal Process(int prevIdx, int seqLeng, int prevValue)
            {
                PrevIdx = prevIdx;
                SeqLeng = seqLeng;
                PrevValue = prevValue;
            }
        }
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var N = init[0];
            var K = init[1];

            var A = new int[N + 1];
            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(ReadLine());
            }
            const int INF = int.MaxValue / 2;
            A[N] = INF * (-1);

            var dp = new Process[N][]
                .Select(v => new Process[2])
                .ToArray();
            dp[0][0] = new Process(INF, 0, INF);
            dp[0][1] = new Process(1, 1, A[0]);
            for (int i = 1; i < N; i++)
            {
                bool insertAble = false;
                if (dp[i - 1][0].PrevValue == INF
                 || Abs(dp[i - 1][0].PrevValue - A[i]) <= K) insertAble = true;
                if (dp[i - 1][1].PrevValue == INF
                 || Abs(dp[i - 1][1].PrevValue - A[i]) <= K) insertAble = true;

                dp[i][0] = dp[i - 1][0];
                if (insertAble)
                {
                    if (dp[i - 1][0].PrevIdx == INF)
                    {
                        dp[i][1] = new Process(i, 1, A[i]);
                    }
                    else
                    {
                        dp[i][1] = new Process(i, dp[i - 1][0].SeqLeng + 1, A[i]);
                    } 

                    dp[i][1].SeqLeng = dp[i - 1][1].SeqLeng + 1 > dp[i][1].SeqLeng
                        ? dp[i - 1][1].SeqLeng + 1 : dp[i][1].SeqLeng;
                }
                else
                {
                    dp[i][1] = dp[i - 1][1];
                }
            }
 
            WriteLine(dp[N - 1][1].SeqLeng.ToString());
            ReadKey();
        }
    }
}
