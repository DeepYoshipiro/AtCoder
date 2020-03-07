using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC155
{
    class ABC155B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            int[] A = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();

            bool approved = true;
            for (int i = 0; i < N; i++)
            {
                if (A[i] % 2 == 0)
                {
                    if (A[i] % 3 != 0 && A[i] % 5 != 0)
                    {
                        approved = false;
                        break;
                    }
                }
            }

            WriteLine(approved ? "APPROVED" : "DENIED");
            ReadKey();
        }
    }
}
