using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

namespace _300pt
{
    class AGC018A
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int K = init[1];

            int[] A = ReadLine().Split(' ')
                .Select(n => int.Parse(n))
                .OrderByDescending(n => n).ToArray();

            if (K > A.First())
            {
                WriteLine("IMPOSSIBLE");
                ReadKey();
                return; 
            }

            AGC018A me = new AGC018A();
            int curGcd = A.First();
            for (int i = 1; i < N; i++)
            {
                curGcd = me.gcd(curGcd, A[i]);
                if (curGcd == 1) break;
            }
            if (K % curGcd == 0)
            {
                WriteLine("POSSIBLE");
            }
            else
            {
                WriteLine("IMPOSSIBLE");
            }

            ReadKey();
        }

        internal int gcd(int m, int n)
        {
            int a = Max(m, n);
            int b = Min(m, n);
            int r = b;
            while (r > 0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
    }
}