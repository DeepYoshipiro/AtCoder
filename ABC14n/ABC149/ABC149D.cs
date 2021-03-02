using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC149
{
    class ABC149D
    {
        static long P;
        static long R;
        static long S;

        static void Main(string[] args)
        {
            int[] init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int K = init[1];

            long[] gainScore = ReadLine().Split()
                .Select(n => long.Parse(n)).ToArray();
            R = gainScore[2];   //駆体の手で得点を作成
            S = gainScore[0];
            P = gainScore[1];

            char[] T = ReadLine().ToCharArray();

            long result = 0;
            for (int rest = 0; rest < K; rest++)
            {
                for (int turn = 0; turn < (N + K - 1) / K; turn++)
                {
                    int hand = turn * K + rest;
                    if (hand >= N) break;
                    result += getWin(T[hand]);
                    if (hand + K < N && T[hand] == T[hand + K])
                    {
                        turn++;
                    }
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }

        static long getWin(char hand)
        {
            switch (hand)
            {
                case 'r':
                    return R;
                case 's':
                    return S;
                case 'p':
                    return P;
            }
            return 0;
        }
    }
}