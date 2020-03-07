using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC154
{
    class ABC154C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());

            int[] A = ReadLine().Split(' ')
                .Select(n => int.Parse(n))
                .OrderBy(n => n).ToArray();
            
            bool result = true;
            int cur = A[0];
            for (int i = 1; i < N; i++)
            {
                if (cur == A[i])
                {
                    result = false;
                    break;
                }
                else
                {
                    cur = A[i];
                }
            }

            WriteLine(result ? "YES" : "NO");
            ReadKey();
        }
    }
}
