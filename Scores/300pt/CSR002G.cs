using System;
using static System.Console;
using System.Linq;
using static System.Math;

namespace _300pt
{
    class CSR002G
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            for (int i = 1; i <= N; i++)
            {
                int[] input = ReadLine().Split(' ')
                    .Select(n => int.Parse(n)).OrderByDescending(n => n).ToArray();
                int A = input[0];
                int B = input[1];
                int R = A;
                while (R != 0) {
                    R = A % B;
                    A = B;
                    B = R;
                }
                WriteLine(A);
            }

            ReadKey();
        }
    }
}
