using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace EDPC
{
    class EDPC_D
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int W = init[1];

            int[] w = new int[N + 1];
            int[] v = new int[N + 1];
            w[0] = 0;
            v[0] = 0;
            for (int i = 1; i <= N; i++)
            {
                int[] info = ReadLine().Split(' ')
                    .Select(n => int.Parse(n)).ToArray();
                w[i] = info[0];
                v[i] = info[1];
            }

            // DP テーブル
            long[][] dpValue = new long[N + 1][];

            // DP テーブル全体を初期化…は不要
            //(最大化問題なので 0 に初期化するが、完了している)

            // DP本体
            dpValue[0] = new long[W + 1];
            HashSet<int> sum_w = new HashSet<int>();
            dpValue[0][0] = 0;
            sum_w.Add(0);
            for (int i = 0; i < N; i++)
            {
                dpValue[i + 1] = new long[W + 1];
                HashSet<int> new_w = new HashSet<int>();
                foreach (int cur_w in sum_w)
                {
                    //新しいアイテムを
                    //…入れない場合
                    chmax(ref dpValue[i + 1][cur_w], dpValue[i][cur_w]);

                    //…入れる場合
                    int in_nap_w = cur_w + w[i + 1];
                    if (in_nap_w <= W)  //重さ制限あり
                    {
                        chmax(ref dpValue[i + 1][in_nap_w], dpValue[i][cur_w] + v[i + 1]);
                        new_w.Add(in_nap_w);
                    }
                }
                sum_w.UnionWith(new_w);
            }

            long result = dpValue[N].Max(n => n);

            WriteLine(result.ToString());
            ReadKey();
        }

        static bool chmax<T>(ref T a, T b) where T : IComparable<T>
            {
                if (b.CompareTo(a) > 0)
                {
                    a = b;
                    return true;
                }
                return false;
            }
    }
}