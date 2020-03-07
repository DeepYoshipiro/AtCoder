using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

namespace _300pt
{
    class ABC032C
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int K = init[1];

            long[] s = new long[N];
            int result = 0;
            for (int i = 0; i < N; i++)
            {
                s[i] = long.Parse(ReadLine());
                if (s[i] == 0) result = N;
            }

            if (result > 0)
            {
                WriteLine(result.ToString());
                ReadKey();
                return;
            }

            long product = 1;
            int right = 0;
            
            for (int left = 0; left < N; left++)
            {
                if (left >= right)
                {
                    right = left;
                    product = s[left];
                }
                while (product <= K && right < N)
                {
                    if (result <= right - left + 1)
                    {
                        result = right - left + 1;
                    }
                    right++;
                    if (right >= N) break;
                    product *= s[right];
                }
                product /= s[left];
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
