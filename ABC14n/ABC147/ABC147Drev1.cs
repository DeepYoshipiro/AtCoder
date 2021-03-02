using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC147
{
    class ABC147Drev1
    {
        static void Main(string[] args)
        {
            ulong N = ulong.Parse(ReadLine());
            ulong[] A = ReadLine().Split()
                .Select(n => ulong.Parse(n)).ToArray();

            ulong sum = 0;
            ulong bas = 1;
            ulong mod = (ulong)Pow(10, 9) + 7;
            for (int digit = 0; digit < 60; digit++)
            {
                ulong digitSum = 0;
                for (ulong i = 0; i < N; i++)
                {
                    digitSum += A[i] % 2;
                    A[i] /= 2;
                }
                sum += bas * digitSum * (N - digitSum);
                sum %= mod;

                bas *= 2;
                bas %= mod;
            }

            WriteLine(sum.ToString());
            ReadKey();
        }
    }
}
