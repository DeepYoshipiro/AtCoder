using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC165
{
    class ABC165A
    {
        static void Main(string[] args)
        {
            int K = int.Parse(ReadLine());

            int[] init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            int A = init[0];
            int B = init[1];

            bool result = false;
            for (int i = A; i <= B; i++)
            {
                if (i % K == 0)
                {
                    result = true;
                    break;
                }
            }

            WriteLine(result ? "OK" : "NG");
            ReadKey();
        }
    }
}
