using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC160
{
    class ABC160E
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            int X = init[0];
            int Y = init[1];
            int A = init[2];
            int B = init[3];
            int C = init[4];

            List<long> p = ReadLine().Split()
                .Select(n => long.Parse(n))
                .OrderByDescending(n => n).ToList();
            if (p.Count() > X) p.RemoveRange(X, p.Count() - X);

            List<long> q = ReadLine().Split()
                .Select(n => long.Parse(n))
                .OrderByDescending(n => n).ToList();
            if (q.Count() > Y) q.RemoveRange(Y, q.Count() - Y);

            List<long> r = ReadLine().Split()
                .Select(n => long.Parse(n))
                .OrderByDescending(n => n).ToList();

            List<long> eatApple = p.Concat(q.Concat(r)).ToList();
            eatApple.Sort();
            eatApple.Reverse();
            eatApple.RemoveRange(X + Y, eatApple.Count() - (X + Y));
            
            WriteLine(eatApple.Sum().ToString());
            ReadKey();
        }
    }
}
