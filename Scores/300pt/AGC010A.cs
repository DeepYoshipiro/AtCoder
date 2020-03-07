using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

namespace _300pt
{
    class AGC010A
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            int[] A = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            
            int odd = 0;
            int even = 0;
            for (int i = 0; i < N; i++)
            {
                if (A[i] % 2 == 0) even++;
                else odd++;
            }

            int pair = odd / 2;
            odd -= pair * 2;
            even += pair;

            if (even > 0) even = 1;

            WriteLine(odd + even == 1 ? "YES" : "NO");
            ReadKey();
        }
    }
}