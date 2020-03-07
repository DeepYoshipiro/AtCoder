using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace TeaBreak003
{
    class TeaBreak003C
    {
        static void Main(string[] args)
        {
            int n = int.Parse(ReadLine());

            int[] p = new int[n];
            int[] q = new int[n];
            for (int i = 0; i < n; i++)
            {
                int[] point = Console.ReadLine().Split(' ')
                        .Select(m => int.Parse(m)).ToArray();
                p[i] = point[0];
                q[i] = point[1];
            }

            int result = 0;
            for (int i = 0; i < n - 2; i++)
            {
                int a = p[i];
                int b = q[i];
                for (int j = i + 1; j < n - 1; j++)
                {
                    int c = p[j];
                    int d = q[j];
                    for (int k = j + 1; k < n; k++)
                    {
                        int e = p[k];
                        int f = q[k];

                        int S = Abs((c - a) * (f - b) - (d - b) * (e - a));
                        if (S > 0 && S % 2 == 0)
                            result++;
                    }
                }
            }

            WriteLine(result.ToString());
            ReadKey();            
        }
    }
}