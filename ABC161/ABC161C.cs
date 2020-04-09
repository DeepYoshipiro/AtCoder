using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC161
{
    class ABC161C
    {
        static void Main(string[] args)
        {
            long[] init = ReadLine().Split(' ')
                .Select(n => long.Parse(n)).ToArray();
            long N = init[0];
            long K = init[1];

            if (N == 0)
            {
                WriteLine("0");
            }
            else
            {
                long result = N % K;
                long cur = result;
                HashSet<long> rest = new HashSet<long>();
                while (result > 0 && !rest.Contains(cur))
                {
                    rest.Add(cur);
                    if (K - (N % K) < result)
                    { 
                        result = K - (N % K);
                        cur = result;
                    }
                }
                WriteLine(result.ToString());
            }
            ReadKey();
        }
    }
}
