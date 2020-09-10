using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ABC105D
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var N = init[0];
            var M = init[1];

            var A = (new int[]{0})
                .Concat(
                    ReadLine().Split().Select(n => int.Parse(n) % M)
                ).ToArray();

            var Sum = new int[N + 1];
            var dic = new Dictionary<int, int>();
            dic.Add(0, 1);
            for (int i = 1; i <= N; i++)
            {
                Sum[i] += Sum[i - 1] + A[i];
                Sum[i] %= M;
                if (dic.ContainsKey(Sum[i]))
                {
                    dic[Sum[i]]++;
                }
                else
                {
                    dic.Add(Sum[i], 1);
                }
            }

            long result = 0;
            foreach (var cnt in dic)
            {
                if (cnt.Value >= 2)
                {
                    result += (long)cnt.Value * ((long)cnt.Value - 1) / 2;
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
