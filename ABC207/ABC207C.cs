using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC207
{
    class ABC207C
    {
        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());

            var interval = new Dictionary<int, int>();
            for (int i = 0; i < N; i++)
            {
                var info = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                var t = info[0];
                var l = info[1] + (t - 1) / 2;
                var r = info[2] - (t - 1) % 2;

                if (interval.ContainsKey(l))
                {
                    interval[l]++;
                }
                else
                {
                    interval.Add(l, 1);
                }

                if (interval.ContainsKey(r + 1))
                {
                    interval[r + 1]--;
                }
                else
                {
                    interval.Add(r + 1, -1);
                }
            }

            var intersection = interval.OrderBy(pair => pair.Key).ToList();
            var preInterCnt = 0;
            var dict = new Dictionary<int, int>();
            foreach (var range in intersection)
            {
                dict.Add(range.Key, range.Value + preInterCnt);
                preInterCnt += range.Value;
            }

            var intersect = false;
            var start = 0;
            var result = 0;
            foreach (var dic in dict)
            {
                if (!intersect && preInterCnt >= 2)
                {
                    intersect = true;
                    start = dic.Key;
                    continue;
                }
                else if (intersect && preInterCnt <= 1)
                {
                    intersect = false;
                    result += dic.Key - start + 1;
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
