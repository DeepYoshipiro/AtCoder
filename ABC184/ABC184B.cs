using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC184
{
    class ABC184B
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var N = init[0];
            var X = init[1];

            var S = ReadLine().ToCharArray();
            
            var result = X;
            for (int i = 0; i < N; i++)
            {
                if (S[i] == 'o')
                {
                    result++;
                }
                else    // 'x'
                {
                    result--;
                    if (result < 0) result = 0;
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
