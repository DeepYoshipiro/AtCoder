using System;
using System.Linq;
using System.Collections.Generic;
using static System.Console;
using static System.Math;

namespace ABC141
{
    class ABC141C
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
               .Select(n => int.Parse(n)).ToArray();

            int N = init[0];    //参加者数
            int K = init[1];    //初期持ち点
            int Q = init[2];    //ラウンド全体の正解数

            int[] P = new int[N + 1];
            //ここでは、参加者の配列は、常に1からはじめます。
            for (int i = 1; i <= N; i++) {  
                //最初に全員、初期持ち点から、
                //ラウンド全体の正解数減点しちゃいます。
                P[i] = K - Q;
            }

            //正解のスコアシートの添え字はゼロからスタート
            for (int j = 0; j < Q; j++) {
                int r = int.Parse(ReadLine());
                //正解した人だけ、ポイント復帰
                P[r]++;
            }

            //勝ち抜けたかな？
            for (int i = 1; i <= N; i++) {
                WriteLine(P[i] > 0 ? "Yes" : "No");
            }

            ReadKey();
        }
    }
}
