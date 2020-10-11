using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace AGC044
{
    class AGC044A
    {
        static void Main(string[] args)
        {
            var T = int.Parse(ReadLine());
            var result = new long[T];

            for (int q = 0; q < T; q++)
            {
                var init = ReadLine().Split()
                    .Select(n => long.Parse(n)).ToArray();
                var N = init[0];
                var A = init[1];
                var B = init[2];
                var C = init[3];
                var D = init[4];

                var dpDic = new Dictionary<long, long>();
                dpDic.Add(N, 0);
                var que = new Queue<long>();
                que.Enqueue(N);

                var divide = new long[]{5, 3, 2};
                var pay = new long[]{C, B, A, D, D};
                while (que.Count() > 0)
                {
                    var cur = que.Dequeue();
                    var next = cur;
                    for (int i = 0; i < 5; i++)
                    {
                        if (i < 3 && cur % divide[i] != 0) continue;

                        switch (i)
                        {
                            case 0:
                            case 1:
                            case 2:
                                next = cur / divide[i];
                                break;
                            case 3:
                                next = cur - 1;
                                break;
                            case 4:
                                next = cur + 1;
                                break;
                        }

                        var amount = dpDic[cur] + pay[i];
                        if (dpDic.ContainsKey(0) && amount >= dpDic[0])
                        {
                            continue;
                        }
                        if (dpDic.ContainsKey(next))
                        {
                            dpDic[next] = Min(amount, dpDic[next]);
                        }
                        else
                        {
                            dpDic.Add(next, dpDic[cur] + pay[i]);
                            que.Enqueue(next);
                        }
                    }
                }
                dpDic[0] = Min(dpDic[1] + pay[3], dpDic[0]);
                result[q] = dpDic[0];
            }

            for (int q = 0; q < T; q++)
            {
                WriteLine(result[q].ToString());
            }
            ReadKey();
        }

    }
}
