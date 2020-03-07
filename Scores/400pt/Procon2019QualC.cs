using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class Procon2019QualC
    {
        static void Main(string[] args)
        {
            long[] init = ReadLine().Split(' ')
                .Select(n => long.Parse(n)).ToArray();
            long K = init[0];
            long A = init[1];
            long B = init[2];

            if (B - A <= 2 || K <= A - 1)
            {
                WriteLine((K + 1).ToString());
                ReadKey();
                return;
            }

            K -= A - 1;
            long exchange = K / 2;
            long result = A + exchange * (B - A);
            K -= exchange * 2;
            result += K;

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
