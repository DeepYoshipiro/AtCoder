using System;
using System.Linq;

namespace _200pt
{
    class ABC129B
    {
        static void Main(string[] args)
        {
            //input
            int N = int.Parse(Console.ReadLine());
            int[] W = Console.ReadLine().Split(' ')
                        .Select(n => int.Parse(n)).ToArray();

            //calculate
            int S1 = 0;
            for (int i = 0; i < N; i++) {
                S1 += W[i];
            }

            int S2 = 0;
            int min = Math.Abs(S1 - S2);
            for (int j = N - 1; j >= 0; j--) {
                S1 -= W[j];
                S2 += W[j];
                if (Math.Abs(S1 - S2) < min) min = Math.Abs(S1 - S2);
            }

            //output
            Console.WriteLine(min.ToString());
            Console.ReadKey();
        }
    }
}
