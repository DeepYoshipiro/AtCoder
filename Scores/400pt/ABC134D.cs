using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ABC134D
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
            int N = init[0];

            int[] a = (new int[]{0})
                    .Concat(ReadLine().Split()
                        .Select(n => int.Parse(n))).ToArray();

            int result = 0;
            Stack<int> b = new Stack<int>();
            for (int i = N; i >= 1; i--)
            {
                int ballCount = 0;
                for (int j = 2 * i; j <= N; j += i)
                {
                    ballCount += a[j];
                }
                ballCount %= 2;
                if (ballCount != a[i])
                {
                    result++;
                    b.Push(i);
                }
            }

            WriteLine(result.ToString());
            while (b.Count > 0)
            {
                Write(b.Pop().ToString() + " ");
            }
            WriteLine();
            ReadKey();
        }
    }
}