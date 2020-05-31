using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

using System.Numerics;

namespace ABC169
{
    class ABC169B
    {
        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());
            var A = ReadLine().Split()
                .Select(n => BigInteger.Parse(n)).ToArray();

            BigInteger result = 1;

            for (int i = 0; i < N; i++)
            {
                if (A[i] == 0)
                {
                    WriteLine(result.ToString());
                    ReadKey();
                    return;
                }
            }

            for (int i = 0; i < N; i++)
            {
                result *= A[i];
                if (result > (BigInteger)Pow(10, 18))
                {
                    result = -1;
                    break;
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
