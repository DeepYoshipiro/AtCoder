using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC179
{
    class ABC179E
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => long.Parse(n)).ToArray();
            var N = init[0];
            var X = init[1];
            var M = init[2];

            var A = new int[M];
            A[X]++;
            var exist = new List<long>();
            long result = X;
            long begin = 0;
            long end = 0;
            var circle = new List<long>();
            for (int i = 2; i <= Min(N, M); i++)
            {
                X = (X * X) % M;
                A[X]++;
                switch (A[X])
                {
                    case 1:
                        result += X;
                        break;
                    case 2:
                        if (begin == 0) begin = i;
                        circle.Add(X);
                        break;
                    case 3:
                        end = i - 1;
                        break;
                }
                if (end > 0) break;
                // if (A[X] == 2)
                // WriteLine("{0} {1}", i, X);
                // if (exist.Contains(X)) break; 
            }

            if (end > 0) 
            {
                result += ((N - end) / circle.Count()) * circle.Sum();
                long rest = (N - end) % circle.Count();
                for (int i = 0; i < rest; i++)
                {
                    result += circle[i];
                }
            }
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
