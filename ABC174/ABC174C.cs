using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC174
{
    class ABC174C
    {
        static void Main(string[] args)
        {
            var K = int.Parse(ReadLine());

            int N = 0;
            int result = 0;

            var usedR = new bool[K];

            do
            {
                result++;
                N *= 10;
                N += 7;
                N %= K;

                if (usedR[N])
                {
                    WriteLine("-1");
                    ReadKey();
                    return;
                }
                usedR[N] = true;
            } while (N != 0);

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
