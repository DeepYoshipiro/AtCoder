using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ARC105
{
    class ARC105B
    {
        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());
            var A = ReadLine().Split()
                .Select(n => int.Parse(n))
                .Distinct()
                .OrderBy(n => n)
                .ToList();

            var dic = new SortedDictionary<int, int>();
            for (int i = 0; i < A.Count() - 1; i++)
            {
                if (dic.ContainsKey(A[i]))
                {
                    dic[A[i]]++;
                }
                else
                {
                    dic.Add(A[i], 1);
                }
            }

            var max = dic.Last().Key;
            var min = dic.First().Key;

            while (dic.Count() > 1)
            {
                if (dic.ContainsKey(max - min))
                {
                    dic[max - min] += dic[max];
                    dic.Remove(max);
                }
                else
                {
                    dic.Add(max - min, dic[max]);
                    dic.Remove(max);
                }
                max = dic.Last().Key;
                min = dic.First().Key;
            }
            // var B = new List<int>();

            // var max = A.Last();
            // var min = A.First();
            // var maxCur = A.Count() - 1;
            // var minCur = 0;
            // var cur = max - min;
            // while (max > min)
            // {
            //     A.RemoveAt(A.Count() - 1);
            //     A.Add(cur);
            //     A.Sort();
            //     max = A.Last();
            //     min = A.First();
            //     cur = max - min;
            // }
            // long result = A.First();
            // var dm = new DiscreteMath();
            // for (int i = 0; i < A.Count() - 1; i++)
            // {
            //     result = dm.GCD(A[i], A[i + 1]);
            // }
            WriteLine(dic.First().Key.ToString());
            ReadKey();
        }

        class DiscreteMath
        {
            internal long GCD(long A, long B)
            {
                long R = A;

                while (R > 0)
                {
                    R = A % B;
                    A = B;
                    B = R;
                }
                return A;
            }
        }
    }
}
