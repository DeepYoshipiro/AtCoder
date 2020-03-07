using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace CyanProblems
{
    class ARC026B
    {
        static void Main(string[] args)
        {
            long N = long.Parse(ReadLine());

            List<long> d = new List<long>();
            if (N != 1) d.Add(1);
            for (long i = 2; i * i <= N; i++)
            {
                if (N % i == 0)
                {
                    d.Add(i);
                    if (N / i != i) d.Add(N / i);
                }
            }

            long Sum = d.Sum();
            if (Sum == N)
            {
                WriteLine("Perfect");
            }
            else if (Sum < N)
            {
                WriteLine("Deficient");
            }
            else    //Sum > N
            {
                WriteLine("Abundant");
            }
            ReadKey();
        }
    }
}
