using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ARC106
{
    class ARC106A
    {
        static void Main(string[] args)
        {
            var N = long.Parse(ReadLine());
            var A = new List<long>(){1};
            var B = new List<long>(){1};

            while (A.Last() <= N)
            {
                A.Add(A.Last() * 3);
            }

            while (B.Last() <= N)
            {
                B.Add(B.Last() * 5);
            }

            for (int i = 1; i < A.Count(); i++)
            {
                for (int j = 1; j < B.Count(); j++)
                {
                    if (A[i] + B[j] == N)
                    {
                        WriteLine("{0} {1}", i, j);
                        ReadKey();
                        return;
                    }
                }
            }
            WriteLine("-1");
            ReadKey();
        }
    }
}
