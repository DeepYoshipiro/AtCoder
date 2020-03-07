using System;
using System.Linq;

namespace abc138
{
    class abc138c
    {
        static void Main(string[] args)
        {
            // input
            int N = int.Parse(Console.ReadLine());
            decimal[] V = Console.ReadLine().Split(' ').Select(d => decimal.Parse(d)).ToArray();

            // calculate
            Array.Sort<decimal>(V);

            for (int i = 0; i < N - 1; i++) {
                V[i + 1] = (V[i] + V[i + 1]) / 2;
            }

            // output
            decimal Result = V[N - 1];
            Console.WriteLine(Result);
        }
    }
}
