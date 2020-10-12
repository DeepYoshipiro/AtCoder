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
                .Select(n => long.Parse(n))
                .Distinct()
                .OrderByDescending(n => n)
                .ToList();

            long result = A.First();
            var dm = new DiscreteMath();
            for (int i = 0; i < A.Count(); i++)
            {
                result = dm.GCD(result, A[i]);
            }

            WriteLine(result.ToString());
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
