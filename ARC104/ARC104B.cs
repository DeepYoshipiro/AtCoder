using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ARC104
{
    class ARC104B
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split().ToArray();
            var N = int.Parse(init[0]);
            var S = (new char[]{' '})
                .Concat(init[1].ToCharArray()).ToArray();

            var DNA = new int[4][]
                .Select(v => new int[N + 1]).ToArray();

            int A = 0;
            int T = 1;
            int G = 2;
            int C = 3;
            for (int i = 1; i <= N; i++)
            {
                for (int u = 0; u < 4; u++)
                {
                    DNA[u][i] = DNA[u][i - 1]; 
                }
                switch (S[i])
                {
                    case 'A':
                        DNA[A][i]++;   
                        break;
                    case 'T':
                        DNA[T][i]++;
                        break;
                    case 'G':
                        DNA[G][i]++;
                        break;
                    case 'C':
                        DNA[C][i]++;
                        break;
                }
            }

            int result = 0;
            for (int s = 1; s < N; s++)
            {
                for (int t = s + 1; t <= N; t++)
                {
                    var dDNA = new int[4];
                    for (int u = 0; u < 4; u++)
                    {
                        dDNA[u] = DNA[u][t] - DNA[u][s - 1]; 
                    }

                    if (dDNA[A] == dDNA[T] && dDNA[G] == dDNA[C])
                    {
                        result++;
                    }
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
