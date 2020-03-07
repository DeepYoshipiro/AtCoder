using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC143
{
    class ABC143Drev
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            int[] L = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).OrderBy(n => n)
                .ToArray();

            //辺A, B, Cを短い順として
            long result = 0;
            for (int a = 0; a < L.Length - 2; a++)
            {
                for (int b = a + 1; b < L.Length - 1; b++)
                {
                    int c = b + 1;
                    if (L[c] >= L[a] + L[b])
                    {
                        continue;
                    }
                    int ok = b + 1;
                    int ng = L.Length;
                    while (ng - ok > 1)
                    {
                        c = (ok + ng) / 2;
                        if (L[c] < L[a] + L[b])
                        {
                            ok = c;
                        }
                        else
                        {
                            ng = c;
                        }
                    }
                    result += ok - b;
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}