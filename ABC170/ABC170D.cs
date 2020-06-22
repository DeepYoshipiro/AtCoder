using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC170
{
    class ABC170D
    {
        static void Main(string[] args)
        {
            var my = new ABC170D();
            var N = int.Parse(ReadLine());
            var A = ReadLine().Split()
                .Select(n => int.Parse(n)).ToList();

            var org = A;
            for (int i = 0; i < N; i++)
            {
                var B = my.Divide(A[i]).ToList();
                org = org.Except(B).ToList();
            }

            WriteLine(org.Count());
            ReadKey();
        }

        internal IEnumerable<int> Divide(int N)
        {
            long firstN = N;
            yield return 1;
            for (int i = 2; i * i <= firstN; i++)
            {
                if (N % i == 0)
                {
                    yield return i;
                    yield return N / i;
                }
            }
            yield break;
        }
    }
}
