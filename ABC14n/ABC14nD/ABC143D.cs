using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC143
{
    class ABC143D
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            List<int> L = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).OrderByDescending(n => n)
                .ToList();

            //辺A, B, Cを長い順として
            long result = 0;
            for (int a = 0; a < L.Count - 2; a++)
            {
                if (L[a] >= L[a + 1] + L[a + 2])
                {
                    L.RemoveAt(a);
                    a--;
                }
                else
                {
                    break;
                }
            }

            for (int b = 1; b < L.Count - 1; b++)
            {
                for (int a = 0; a < b; a++)
                {
                    for (int c = b + 1; c < L.Count; c++)
                    {
                        int s = L[a] - L[b];
                        int t = L[b] - L[c];
                        int u = Abs(L[b] - t);
                        if (u < s)
                            result++;
                    }
                }
            }          

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}