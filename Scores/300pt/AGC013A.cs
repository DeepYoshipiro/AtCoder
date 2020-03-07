using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

namespace _300pt
{
    class AGC013A
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            int[] A = ReadLine().Split()
                .Select(n=> int.Parse(n)).ToArray();

            int interval = 1;
            int mode = 0;

            for (int i = 1; i < N; i++)
            {
                int diff = A[i] - A[i - 1];
                if (Sign(diff * mode) < 0)
                {
                    interval++;
                    mode = 0;
                }
                else
                {
                    mode += Sign(diff);
                }
            }

            WriteLine(interval.ToString());
            ReadKey();
        }
    }
}
