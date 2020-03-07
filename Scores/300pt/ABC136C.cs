using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ARC136C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());

            int[] H = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();

            for (int i = N - 1; i > 0; i--)
            {
                if (H[i - 1] > H[i])
                    H[i - 1]--;
            }

            bool result = true;
            for (int i = 0; i < N - 1; i++)
            {
                if (H[i] > H[i + 1])
                {
                    result = false;
                    break;
                }
            }

            WriteLine(result ? "Yes" : "No");
            ReadKey();
        }
    }
}