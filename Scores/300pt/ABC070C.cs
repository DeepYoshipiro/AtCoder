using System;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ABC070C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            long lcm = long.Parse(ReadLine());
            for (int i = 2; i <= N; i++)
            {
                long Ti = long.Parse(ReadLine());
                long A = Max(lcm, Ti);
                long B = Min(lcm, Ti);
                long R = A;
                while (R != 0) {
                    R = A % B;
                    A = B;
                    B = R;
                }
                long gcd = A;
                lcm = lcm / gcd * Ti;
            }

            WriteLine(lcm.ToString());
            ReadKey();
        }
    }
}
