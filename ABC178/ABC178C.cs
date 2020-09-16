using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC178
{
    class ABC178C
    {
        static long N;
        static long result;

        static void Main(string[] args)
        {
            N = long.Parse(ReadLine());
            
            if (N == 1)
            {
                WriteLine("0");
                ReadKey();
                return;
            }

            DFS(0, 1, false, false);

            WriteLine(result.ToString());
            ReadKey();
        }

        static void DFS(long i, long pattern, bool existZero, bool existNine)
        {
            if (i > N) 
            {
                return;
            }

            long mod = (long)Pow(10, 9) + 7;
            if (existZero && existNine)
            {
                result += pattern;
                for (long j = i + 1; j <= N; j++)
                {
                    result *= 10;
                }
                return;
            }
            else if (existZero || existNine)
            {
                DFS(i + 1, pattern, true, true);
                pattern *= 9;
                DFS(i + 1, pattern % mod, existZero, existNine);
            }
            else
            {
                DFS(i + 1, pattern, true, false);
                DFS(i + 1, pattern, false, true);
                pattern *= 8;
                DFS(i + 1, pattern % mod, existZero, existNine);
            }
            return;            
        }
    }
}
