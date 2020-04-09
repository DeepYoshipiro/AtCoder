using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC160
{
    class ABC160D
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int X = init[1];
            int Y = init[2];

            HashSet<Tuple<int, int>> arriveAble = new HashSet<Tuple<int, int>>();
            bool[][] alreadyArrived = new bool[N + 1][];
            for (int i = 1; i <= N; i++)
            {
                alreadyArrived[i] = new bool[N + 1];
            }

            for (int k = 1; k <= N - 1; k++)    //距離でループ
            {
                int result = 0;
                //int counted = arriveAble.Count();
                for (int i = 1; i <= N - 1; i++)    //駅でループ
                {
                    if (i + k <= N) //ずっとローカル線 
                    {
                        if (!alreadyArrived[i][i + k])
                        {
                            alreadyArrived[i][i + k] = true;
                            result++;
                        }
                        // arriveAble.Add(new Tuple<int, int>(i, i + k));
                    }
                    else
                    {
                        continue;
                    }

                    // 快速線に乗れるかどうか。
                    // （スタートが快速線外の場合）
                    int left = 0;
                    if (i + (k - 1) >= X && i <= X) //始点が快速駅始発の場合も含む
                    {
                        left = k - (X - i);     //快速に乗るまでの何駅
                        if (left >= 1)
                        {
                            left--;
                            if (Y + left <= N)
                                if (!alreadyArrived[i][Y + left])
                                {
                                    alreadyArrived[i][Y + left] = true;
                                    result++;
                                }
                                // arriveAble.Add(new Tuple<int, int>(i, Y + left));   //快速駅から下りて、進む場合
                            if (Y - left > i)
                                if (!alreadyArrived[i][Y - left])
                                {
                                    alreadyArrived[i][Y - left] = true;
                                    result++;
                                }
                                // arriveAble.Add(new Tuple<int, int>(i, Y - left));   //戻る場合
                        }
                    }
                    else if (X < i && i < Y)    //戻って快速乗るパターン
                    {
                        left = k - (i - X);
                        if (left >= 1)
                        {
                            left--;
                            if (Y + left <= N)
                                if (!alreadyArrived[i][Y + left])
                                {
                                    alreadyArrived[i][Y + left] = true;
                                    result++;
                                }
                                // arriveAble.Add(new Tuple<int, int>(i, Y + left));
                            if (Y - left > i)
                                if (!alreadyArrived[i][Y - left])
                                {
                                    alreadyArrived[i][Y - left] = true;
                                    result++;
                                }
                                // arriveAble.Add(new Tuple<int, int>(i, Y - left));
                        } 
                    }
                }
                // result = arriveAble.Count() - counted;
                WriteLine(result.ToString());
            }
            ReadKey();
        }
    }
}
