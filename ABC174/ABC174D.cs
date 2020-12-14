using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC174
{
    class ABC174D
    {
        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());
            var C = ReadLine().ToCharArray();

            int result = 0;
            int lastR = N - 1;
            for (int i = 0; i < N; i++)
            {
                if (C[i] == 'W')
                {
                    while (C[lastR] == 'W' && i < lastR)
                    {
                        lastR--;
                    }
                    if (i >= lastR) break;
                    result++;
                    lastR--;
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
