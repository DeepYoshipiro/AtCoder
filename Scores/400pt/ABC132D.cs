using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ABC132D
    {
        static List<int> Bin;

        static void Main(string[] args)
        {
            var init = ReadLine().Split(' ')
                .Select(n => long.Parse(n)).ToArray();
            var N = init[0];
            var K = init[1];

            Bin = Binary((long)(Pow(10, 9) + 5));
            var BlueSeparate = Comb(K - 1, K - 1);
            var RedSeparate = Comb(N - K + 1, K);
            long result = 1;
            for (int i = 0; i < K; i++)
            {
                result = BlueSeparate[i];
                result *= RedSeparate[i + 1];
                result %= (long)(Pow(10, 9) + 7);
                WriteLine(result.ToString());
            }
            ReadKey();
        }

        static List<long> Comb(long N, long R)
        {
            var result = new List<long>();
            result.Add(1);
            long cur = 1;
            for (long i = 1; i <= R; i++)
            {
                cur *= (N + 1 - i);
                cur *= Inv(i);
                cur %= (long)(Pow(10, 9) + 7);
                result.Add(cur);
            }
            return result;
        }

        static List<int> Binary(long M)
        {
            var result = new List<int>();
            while (M > 0)
            {
                int R = (int)(M % 2);
                M -= R;
                M /= 2;
                result.Add(R); 
            }
            return result;
        }

        static long Inv(long a)
        {
            long result = 1;
            foreach (long x in Bin)
            {
                if (x == 1)
                {  
                    result *= a;
                    result %= (long)(Pow(10, 9) + 7);
                }
                a *= a;
                a %= (long)(Pow(10, 9) + 7);
            }
            return result;
        }
    }
}