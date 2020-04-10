using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC161
{
    class ABC161F
    {
        static void Main(string[] args)
        {
            long N = long.Parse(ReadLine());

            IEnumerable<long> divideN = Divide(N);
            List<long> result = new List<long>();
            foreach (long d in divideN)
            {
                long cur = N;
                while (cur % d == 0)
                {
                    cur /= d;
                }
                if (cur % d == 1) result.Add(d); 
            }

            if (N - 1 > 1)
            {
                result.AddRange(Divide(N - 1).ToList());
            }

            WriteLine(result.Distinct().Count());
            ReadKey();
        }

        static IEnumerable<long> Divide(long N)
        {
            List<long> result = new List<long>();
            for (long i = 2; i * i <= N; i++)
            {
                if (N % i == 0)
                {
                    yield return i;
                    yield return N / i;
                }
            }
            yield return N;
        }   
    }
}
