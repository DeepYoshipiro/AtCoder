using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC189
{
    class ABC189C
    {
        static void Main(string[] args)
        {
            var N = long.Parse(ReadLine());
            var A = ReadLine().Split()
                .Select(n => long.Parse(n))
                .Concat(new long[]{0}).ToArray();

            long result = 0;
            for (int i = 0; i < N; i++)
            {
                long x = A[i];
                int l = i;
                for (l = i; l >= 0; l--)
                {
                    if (A[l] < x)
                    {
                        break;
                    }
                }
                l++;
                for (int r = i + 1; r <= N; r++)
                {
                    if (A[r] < x)
                    {
                        if (result < (r - l) * x)
                        {
                            result = (r - l) * x;
                        } 
                        break;
                    }
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
