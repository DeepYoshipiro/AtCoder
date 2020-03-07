using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

namespace _300pt
{
    class ABC109C
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int X = init[1];

            int[] x = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();

            int result = Abs(X - x[0]);
            for (int i = 1; i < N; i++)
            {
                int diff_x = Abs(X - x[i]);
                int A = Max(result, diff_x);
                int B = Min(result, diff_x);
                int R = A;
                while (R != 0) {
                    R = A % B;
                    A = B;
                    B = R;
                }
                result = A;
                if (result == 1) break;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
