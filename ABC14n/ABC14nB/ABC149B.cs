using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC149
{
    class ABC149B
    {
        static void Main(string[] args)
        {
            long[] init = ReadLine().Split()
                .Select(n => long.Parse(n)).ToArray();
            long A = init[0];
            long B = init[1];
            long K = init[2];

            A -= K;
            K = 0;
            if (A < 0)
            {
                K = -A;
                A = 0;
            }
            if (K > 0)
            {
                B -= K;
                if (B < 0) B = 0;
            }

            WriteLine(A.ToString() + " " + B.ToString());
            ReadKey();
        }
    }
}
